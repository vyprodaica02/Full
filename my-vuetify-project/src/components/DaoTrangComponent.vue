<template>
  <div>
    <v-app class="bodybg">
      <TablueDaoTrang
        :DataLotus="DataLotus[0]"
        :DataInput="DataInput"
        :DataHeader="DataHeader"
        :stringAdd="stringDT"
        @thems="addDT"
      ></TablueDaoTrang>
    </v-app>
    <!-- <CapNhatDaoTrang :isOpenSuaDT="open" @clickSuaDT="handleClickOverlay" /> -->
    <ThemDaoTrang :isOpenDT="openthemDT" @clickThemDT="handleClickThemDT" />

    <!-- Đặt tên sự kiện để bắt sự kiện khi dữ liệu được cập nhật -->
    <CapNhatDaoTrang
      :isOpenSuaDT="OpenSuaDT"
      :selectedRowData="selectedRowData"
    />
  </div>
</template>

<script>
import TablueDaoTrang from "./TableDaoTrang.vue";
import ThemDaoTrang from "./ThemDaoTrang.vue";
import CapNhatDaoTrang from "./CapNhatDaoTrang.vue";

export default {
  components: {
    TablueDaoTrang,
    ThemDaoTrang,
    CapNhatDaoTrang,
  },
  data() {
    return {
      //tiêu đề
      OpenSuaDT: false,
      DataLotus: [
        {
          title: "Giám sát học tập",
          btn: "Tạo tài khoản",
        },
      ],
      //string nút thêm
      stringDT: "Thêm Đào Trang",
      //thanh tìm kiếm
      DataInput: [
        "Tên",
        "Pháp danh",
        "Email",
        "Giới tính",
        "Trạng thái phật tử",
      ],
      DataHeader: [
        "ID",
        "Đã kết thúc",
        "Nơi tổ chức",
        "Số thành viên",
        "Thời Gian tổ chức",
      ],
      //data API
      //open thêm
      openthemDT: false,
      // Dữ liệu của hàng đã được chọn để sửa đổi
      selectedRowData: {},
    };
  },
  methods: {
    addDT() {
      this.openthemDT = !this.openthemDT;
    },
    handleClickThemDT() {
      this.openthemDT = false;
    },
  },
};
</script>

<style scoped>
.bodybg {
  background: #fcedda;
}
</style>
