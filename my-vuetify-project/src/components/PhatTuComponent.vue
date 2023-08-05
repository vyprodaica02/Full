<template>
  <div>
    <v-app class="bodybg">
      <TablePhatTu
        :DataLotus="DataLotus[0]"
        :DataInput="DataInput"
        :DataAPi="DataAPi"
        :DataHeader="DataHeader"
        @clickModal="openModal"
      ></TablePhatTu>
    </v-app>
    <CapNhatPhattu :isOpen="open" @clickOverlay="handleClickOverlay" />
  </div>
</template>

<script>
import TablePhatTu from "./TablePhatTu.vue";
import CapNhatPhattu from "./CapNhatPhattu";
import axios from "axios";
export default {
  components: {
    TablePhatTu,
    CapNhatPhattu,
  },
  data() {
    return {
      DataAPi: {},
      DataLotus: [
        {
          title: "Giám sát học tập",
          btn: "Tạo tài khoản",
        },
      ],
      DataHeader: [
        "Email",
        "Giới Tính",
        "Trạng Thái",
        "Ngày Sinh",
        "Số điện thoại",
      ],
      DataInput: [
        "Tên",
        "Pháp danh",
        "Email",
        "Giới tính",
        "Trạng thái phật tử",
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
        .get("https://localhost:7024/api/phattu/layALLphantu", {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        })
        .then((res) => {
          // Gán dữ liệu từ API vào biến DataAPi
          this.DataAPi = res.data.map((item) => ({
            email: item.email,
            gioitinh: item.gioitinh,
            isActive: item.isActive,
            ngaysinh: item.ngaysinh,
            sodienthoai: item.sodienthoai,
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
