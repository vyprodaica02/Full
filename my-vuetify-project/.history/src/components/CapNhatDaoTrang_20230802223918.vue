<template>
  <div
    class="overlay d-flex align-center justify-center"
    v-if="isOpenSuaDT"
    @click="openSuaDT()"
  >
    <div class="modal-main rounded d-flex flex-column pa-6" @click.stop>
      <div class="text-h6 font-weight-bold">Thông Tin Sửa Đạo Tràng</div>
      <v-card>
        <v-container>
          <v-row>
            <v-col cols="6">
              <div class="text-body-2 font-weight-bold mb-3">Nơi Tổ chức</div>
              <v-text-field
                density="compact"
                variant="solo"
                label="Nơi Tổ chức"
                v-model="editedData.noitochuc"
              ></v-text-field>
            </v-col>

            <v-col cols="6">
              <div class="text-body-2 font-weight-bold mb-3">
                Thời Gian Tổ chức
              </div>
              <v-text-field
                density="compact"
                variant="solo"
                type="date"
                label="Thời gian tổ chức"
                v-model="editedData.thoigiantochuc"
              ></v-text-field>
            </v-col>

            <v-col cols="4">
              <div class="text-body-2 font-weight-bold mb-3">đã kết thúc</div>
              <label>
                <input
                  type="radio"
                  v-model="editedData.daketthuc"
                  value="true"
                />
                đã kết thúc
              </label>
              <label>
                <input
                  type="radio"
                  v-model="editedData.daketthuc"
                  value="false"
                />
                Chưa kết thúc
              </label>
              <p>đã chọn: {{ editedData.daketthuc }}</p>
            </v-col>
          </v-row>
          <div class="mt-3 text-center">
            <v-btn @click="saveChanges">Save</v-btn>
          </div>
        </v-container>
      </v-card>
    </div>
  </div>
</template>

<script>
import { mapActions } from "vuex";
export default {
  props: {
    isOpenSuaDT: {
      type: Boolean,
      required: true,
    },
    value: Boolean,
    selectedRowData: {
      type: Object,
      required: true,
    },
  },
  data() {
    return {
      editedData: {
        daotrangid: Number,
        daketthuc: Boolean,
        noitochuc: String,
      },
      closeModalIncomp: false,
    };
  },
  watch: {
    selectedRowData: {
      immediate: true,
      handler(newVal) {
        // Sao chép dữ liệu bằng cách parse và stringify
        this.editedData = JSON.parse(JSON.stringify(newVal));
      },
    },
  },
  methods: {
    openSuaDT() {
      this.$emit("clickSuaDT");
    },

    // Xử lý khi nhấn nút "Save"
    saveChanges() {
      // Kiểm tra xem this.editedData có chứa trường id không
      if (
        !Object.prototype.hasOwnProperty.call(this.editedData, "daotrangid") ||
        this.editedData.daotrangid === null ||
        this.editedData.daotrangid === ""
      ) {
        alert("Lỗi: Vui lòng chọn một bản ghi để sửa đổi.");
        return;
      }

      // Gọi action saveChanges từ Vuex store
      this.saveChangesAction(this.editedData)
        .then(() => {
          // Đóng modal sau khi hoàn tất quá trình lưu
          this.$emit("clickSuaDT");
        })
        .catch((error) => {
          // Xử lý lỗi nếu có
          console.error("Lỗi khi lưu dữ liệu:", error);
        });
    },

    ...mapActions(["saveChangesAction"]),
  },
};
</script>
<style>
/* Các phần style khác ở đây */
</style>
