<template>
  <div>
    <v-app class="bodybg">
      <TableDonDangKy
        :DataLotus="DataLotus[0]"
        :DataInput="DataInput"
        :DataAPi="DataAPi"
        :DataHeader="DataHeader"
        @clickModal="openModal"
      ></TableDonDangKy>
    </v-app>
    <CapNhatPhattu :isOpen="open" @clickOverlay="handleClickOverlay" />
  </div>
</template>

<script>
import TableDonDangKy from "./TableDonDangKy.vue";
import CapNhatPhattu from "./CapNhatPhattu";
import axios from "axios";
export default {
  components: {
    TableDonDangKy,
    CapNhatPhattu,
  },
  data() {
    return {
      DataAPi: [],
      DataLotus: [
        {
          title: "Giám sát học tập",
          btn: "Tạo tài khoản",
        },
      ],

      DataInput: [
        "Tên",
        "Pháp danh",
        "Email",
        "Giới tính",
        "Trạng thái phật tử",
      ],
      DataHeader: [
        "ID",
        "Ngày gửi đơn",
        "Ngày sử lý",
        "Người sử lý",
        "Trạng Thái đơn",
      ],
      open: false,
    };
  },
  methods: {
    openModal() {
      this.open = !this.open;
      console.log("oke");
    },
    handleClickOverlay() {
      this.open = false;
    },
    getpost() {
      const token = document.cookie.replace(
        /(?:(?:^|.*;\s*)jwtToken\s*=\s*([^;]*).*$)|^.*$/,
        "$1"
      );
      axios
        .get("https://localhost:7024/api/DonDangKy/layAllDanhSachDonDangKy", {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        })
        .then((res) => {
          // Gán dữ liệu từ API vào biến DataAPi
          this.DataAPi = res.data.map((item) => ({
            dondangkyid: item.dondangkyid,
            ngayguidon: item.ngayguidon,
            ngayxuly: item.ngayxuly,
            nguoixuly: item.nguoixuly,
            trangthaidon: item.trangthaidon,
          }));
        })
        .catch((error) => {
          // Gọi lỗi
          console.error(error);
        });
    },
  },
  created() {
    // gọi axios
    this.getpost();
  },

  computed: {},
};
</script>

<style scoped>
.bodybg {
  background: #fcedda;
}
</style>
