<template>
  <v-container class="">
    <v-row>
      <v-col cols="12">
        <div class="TableLotus">
          <div class="main-content mx-auto">
            <div class="location-lotus pb-4">
              <p class="text-color-gray text-h6 font-weight-bold">
                Home > {{ DataLotus.title }}
              </p>
              <p class="main-title text-color-gray text-subtitle-2">
                {{ DataLotus.title }}
              </p>
            </div>
            <v-card
              class="sear-input d-flex bg-white pa-6 mb-5 d-flex flex-column"
            >
              <v-row>
                <v-col class="d-flex justify-end">
                  <v-icon class="icon-border-grean pa-4">mdi-magnify</v-icon>
                </v-col>
              </v-row>
              <v-row>
                <v-col v-for="index in DataInput" :key="index" cols="3">
                  <div class="text-body-2 font-weight-bold mb-3">
                    {{ index }}
                  </div>
                  <v-text-field
                    class="mt-3"
                    density="compact"
                    variant="solo"
                  ></v-text-field>
                </v-col>
              </v-row>
            </v-card>
            <div class="card">
              <v-card min-height="500">
                <div class="main-card">
                  <v-container
                    class="d-flex align-center justify-space-between"
                  >
                    <div class="mt-10 d-flex pa-1 pl-2">
                      <v-select
                        v-model="currentPage"
                        outlined
                        label="Trang"
                        dense
                        density="compact"
                        variant="solo"
                        class="custom-dropdown"
                      />
                    </div>
                    <div>
                      <v-btn v-if="showButton" @click="themElement()">{{
                        stringAdd
                      }}</v-btn>
                    </div>
                  </v-container>
                  <div>
                    <v-table class="table">
                      <thead>
                        <tr>
                          <th v-for="item in DataHeader" :key="item.index">
                            {{ item }}
                          </th>
                          <th class="d-flex align-center justify-center">
                            Thao tác
                          </th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr
                          v-for="item in DataAPiFromStore"
                          :key="item.daotrangid"
                        >
                          <td>
                            {{ item.daotrangid }}
                          </td>
                          <td>
                            {{ item.daketthuc }}
                          </td>
                          <td>
                            {{ item.noitochuc }}
                          </td>
                          <td>
                            {{ item.sothanhvienthamgia }}
                          </td>
                          <td>
                            {{ item.thoigiantochuc }}
                          </td>
                          <td class="d-flex justify-center align-center">
                            <v-icon v-if="showIconPlus" class="plus-icon click"
                              >mdi-plus</v-icon
                            >
                            <v-icon class="pencil" @click="openSuaDT(item)"
                              >mdi-pencil</v-icon
                            >
                            <v-icon
                              class="trash click"
                              @click="showDeleteConfirmation"
                              >mdi-trash-can-outline</v-icon
                            >
                          </td>
                        </tr>
                      </tbody>
                    </v-table>
                  </div>
                </div>
              </v-card>
            </div>
          </div>
        </div>
      </v-col>
    </v-row>
    <CapNhatDaoTrang
      :isOpenSuaDT="open"
      @clickSuaDT="handleClickOverlay"
      :selectedRowData="selectedRowData"
    />
  </v-container>
</template>

<script>
import Swal from "sweetalert2";
import CapNhatDaoTrang from "./CapNhatDaoTrang.vue";
import { mapGetters, mapActions } from "vuex"; // Import mapGetters and mapActions

export default {
  components: {
    CapNhatDaoTrang,
  },
  data() {
    return {
      selectedRowData: {},
      showButton: true,
      showIconPlus: true,
      items: [
        { id: 1, name: "Item 1" },
        { id: 2, name: "Item 2" },
        // Add more items here
      ],
      itemsPerPage: 5,
      currentPage: 1,
      KeyAPiTable: [],
      open: false,
    };
  },

  props: {
    stringAdd: {
      type: String,
    },
    DataLotus: {
      type: Object,
    },

    DataInput: {
      type: Array,
    },
    DataHeader: {
      type: Array,
    },
  },
  methods: {
    openSuaDT(selectedRowData) {
      this.selectedRowData = selectedRowData;
      this.open = !this.open;
    },
    handleClickOverlay() {
      this.open = false;
    },
    themElement() {
      this.$emit("thems");
    },

    showDeleteConfirmation() {
      // Hiển thị hộp thoại xác nhận xóa bằng SweetAlert2
      Swal.fire({
        title: "Bạn có chắc chắn?",
        text: "Bạn sẽ không thể hoàn tác thao tác này!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Có, xóa đi!",
      }).then((result) => {
        // Kiểm tra xem người dùng đã nhấp vào nút xác nhận hay chưa
        if (result.isConfirmed) {
          // Hiển thị thông báo xóa thành công bằng SweetAlert2
          Swal.fire("Đã xóa!", "Tập tin của bạn đã được xóa.", "success");

          // Thêm mã xử lý xóa thực tế tại đây (ví dụ: gọi API để xóa tập tin)
          // ...
        }
      });
    },
  },
  created() {
    // Gọi action fetchData để lấy dữ liệu từ API khi component được tạo
    this.layDanhSachDaoTrang();
  },
  ...mapActions(["layDanhSachDaoTrang"]),

  computed: {
    // Sử dụng mapGetters để liên kết với getter daoTrangData từ Vuex
    ...mapGetters(["daoTrangData"]),

    // Dữ liệu API của bảng
    DataAPiFromStore() {
      // Trả về dữ liệu từ Vuex store bằng getter daoTrangData
      return this.daoTrangData;
    },
  },
};
</script>

<style scoped></style>
