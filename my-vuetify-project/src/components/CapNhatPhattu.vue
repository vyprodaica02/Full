<template>
  <div
    class="overlay d-flex align-center justify-center"
    v-if="isOpen"
    @click="offModal()"
  >
    <div class="modal-main rounded d-flex flex-column pa-6" @click.stop>
      <div class="text-h6 font-weight-bold">Thông Tin người dùng</div>
      <v-card>
        <div>
          <v-container>
            <img
              src="https://surgassociates.com/wp-content/uploads/610-6104451_image-placeholder-png-user-profile-placeholder-image-png.jpg"
              alt=""
              class="avata-user"
            />
            <div class="mt-5">
              <label for="select-img" class="btn-select_file">chọn ảnh</label>
              <input type="file" id="select-img" class="display-none" />
            </div>
          </v-container>
          <v-container>
            <v-row>
              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Họ tên</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Họ tên"
                ></v-text-field>
              </v-col>

              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Pháp danh</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Pháp danh"
                ></v-text-field>
              </v-col>

              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Email</div>
                <v-text-field density="compact" variant="solo" label="Email">
                </v-text-field>
              </v-col>

              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">
                  Số điện thoại
                </div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  label="Số điện thoại"
                ></v-text-field>
              </v-col>

              <v-col cols="6">
                <div class="text-body-2 font-weight-bold mb-3">Ngày Sinh</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  type="date"
                  labe="Ngày Sinh"
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
                <div class="text-body-2 font-weight-bold mb-3">Giới tính</div>
                <p>Chọn giới tính:</p>
                <label>
                  <input type="radio" v-model="selectedGender" value="male" />
                  Nam
                </label>
                <label>
                  <input type="radio" v-model="selectedGender" value="female" />
                  Nữ
                </label>
                <p>Giới tính đã chọn: {{ selectedGender }}</p>
              </v-col>
              <v-col cols="4">
                <div class="text-body-2 font-weight-bold mb-3">Hoàn tục</div>
                <v-text-field
                  density="compact"
                  variant="solo"
                  type="number"
                ></v-text-field>
              </v-col>
              <v-col cols="4">
                <div class="text-body-2 font-weight-bold mb-3">
                  Ngày hoàn tục
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
      this.$emit("clickOverlay");
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
