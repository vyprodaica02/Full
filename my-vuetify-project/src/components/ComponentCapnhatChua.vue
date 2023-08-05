<template>
  <div
    class="overlay d-flex align-center justify-center"
    v-if="isOpen"
    @click="offModal()"
  >
    <div class="modal-main rounded d-flex flex-column pa-6" @click.stop>
      <div class="text-h6 font-weight-bold">Thông Tin Đạo Tràng</div>
      <v-card>
        <div>
          <v-container>
            <v-row>
              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Tên chùa</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Tên chùa"
                ></v-text-field>
              </v-col>
              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Địa Chỉ</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Địa Chỉ"
                ></v-text-field>
              </v-col>
              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Trụ Trì</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Trụ trì"
                  type="number"
                ></v-text-field>
              </v-col>

              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">
                  Ngày Thành Lập
                </div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  type="date"
                  labe="  Ngày Thành Lập"
                ></v-text-field>
              </v-col>

              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">
                  Ngày cập nhập
                </div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  type="date"
                ></v-text-field>
              </v-col>
            </v-row>
          </v-container>
        </div>
      </v-card>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    isOpen: {
      type: Boolean,
    },
    value: Boolean,
  },
  data() {
    return {
      selectedGender: this.value, // Khởi tạo giá trị ban đầu cho radio từ prop
    };
  },
  methods: {
    offModal() {
      this.$emit("offmodal");
    },
  },
  watch: {
    selectedGender(newVal) {
      // Thông báo về sự thay đổi giới tính lên component cha
      this.$emit("input", newVal);
    },
  },
};
</script>

<style>
.avata-user {
  width: 150px;
  height: 150px;
}
.btn-select_file {
  border: 1px solid #ccc;
  padding: 10px;
  max-width: 100px;
  background: #78c1f3;
  border-radius: 5px;
}
</style>
