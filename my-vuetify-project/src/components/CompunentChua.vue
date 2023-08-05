<template>
  <div>
    <v-app class="bodybg">
      <TableChuaComponent
        :DataLotus="DataLotus[0]"
        :DataInput="DataInput"
        :DataAPi="DataAPi"
        :DataHeader="DataHeader"
        :stringAdd="stringChua"
        @clickModal="openModal"
        @thems="addChua"
      ></TableChuaComponent>
    </v-app>
    <ComponentCapnhatChua :isOpen="open" @offmodal="handleClickOverlay" />
    <ComponentThemChua
      :isOpenThemC="openThem"
      @clickThemChua="handleClickThem"
    />
  </div>
</template>

<script>
import TableChuaComponent from "./TableChuaComponent.vue";
import ComponentCapnhatChua from "./ComponentCapnhatChua.vue";
import ComponentThemChua from "./ComponentThemChua";
import axios from "axios";
export default {
  components: {
    TableChuaComponent,
    ComponentCapnhatChua,
    ComponentThemChua,
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
      stringChua: "Thêm Chùa",
      DataInput: [
        "Tên",
        "Pháp danh",
        "Email",
        "Giới tính",
        "Trạng thái phật tử",
      ],
      DataHeader: ["ID", "Địa chỉ", "Ngày thành lập", "Tên Chùa", "Trụ trì"],
      open: false,
      openThem: false,
    };
  },
  methods: {
    openModal() {
      this.open = !this.open;
    },
    handleClickOverlay() {
      this.open = false;
    },

    addChua() {
      this.openThem = !this.openThem;
    },
    handleClickThem() {
      this.openThem = false;
    },

    getpost() {
      axios
        .get("https://localhost:7024/api/Chua/layAllChua")
        .then((res) => {
          // Trích xuất chỉ những trường cần thiết từ API
          this.DataAPi = res.data.map((item) => ({
            chuaid: item.chuaid,
            diachi: item.diachi,
            ngaythanhlap: item.ngaythanhlap,
            tenchua: item.tenchua,
            trutri: item.trutri,
          }));
        })
        .catch((error) => {
          // gọi lỗi
          console.error(error);
        });
    },
  },
  created() {
    // gọi axios
    this.getpost();
  },
};
</script>

<style scoped>
.bodybg {
  background: #fcedda;
}
</style>
