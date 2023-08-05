<template>
  <div
    class="overlay d-flex align-center justify-center"
    v-if="isOpenDT"
    @click="openThemDT()"
  >
    <div class="modal-main rounded d-flex flex-column pa-6" @click.stop>
      <div class="text-h6 font-weight-bold">Thông Tin Thêm Đạo Tràng</div>
      <v-card>
        <div>
          <v-container>
            <v-row>
              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Nơi Tổ chức</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Nơi Tổ chức"
                ></v-text-field>
              </v-col>
              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Trụ trì</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Trụ trì"
                  type="number"
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
                  labe="Thời gian tổ chức"
                ></v-text-field>
              </v-col>

              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">
                  Ngày xuất gia
                </div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  type="date"
                ></v-text-field>
              </v-col>
              <v-col cols="4">
                <div class="text-body-2 font-weight-bold mb-3">đã kết thúc</div>
                <label>
                  <input type="radio" v-model="selectedGender" value="true" />
                  đã kết thúc
                </label>
                <label>
                  <input type="radio" v-model="selectedGender" value="false" />
                  Chưa kết thúc
                </label>
                <p>đã chọn: {{ selectedGender }}</p>
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
    isOpenDT: {
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
    openThemDT() {
      this.$emit("clickThemDT");
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
