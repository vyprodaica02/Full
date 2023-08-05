<template>
  <div>
    <HeaderLogin />
    <v-form class="w-50 ma-auto mt-12 border rounded-lg pa-10">
      <p class="text-h5 text-center border-b pb-5">ĐĂNG NHẬP</p>
      <div class="mt-16">
        <v-card
          class="mx-auto pa-12 pb-8"
          elevation="2"
          max-width="448"
          rounded="lg"
        >
          <div class="text-subtitle-1 text-medium-emphasis">Tên đăng nhập:</div>

          <v-text-field
            v-model="email"
            density="compact"
            placeholder="Nhập tên đăng nhập"
            variant="outlined"
          ></v-text-field>

          <div
            class="text-subtitle-1 text-medium-emphasis d-flex align-center justify-space-between"
          >
            Mật khẩu:
          </div>

          <v-text-field
            v-model="password"
            :append-inner-icon="visible ? 'mdi-eye-off' : 'mdi-eye'"
            :type="visible ? 'text' : 'password'"
            density="compact"
            placeholder="Nhập mật khẩu"
            variant="outlined"
            @click:append-inner="visible = !visible"
          ></v-text-field>

          <!-- Hiển thị thông báo lỗi -->
          <div class="error-message" v-if="error">{{ error }}</div>

          <v-btn
            block
            class="mb-8 input-btn bgs-primary"
            size="large"
            variant="tonal"
            @click="handleLogin"
          >
            Đăng nhập
          </v-btn>
          <router-link
            to="/ComponentRegister"
            class="link-create-user d-flex justify-center color-primary"
          >
            Tạo tài Khoản
          </router-link>
        </v-card>
      </div>
    </v-form>
  </div>
</template>

<script>
import HeaderLogin from "../components/HeaderLogin.vue";
import axios from "axios";
import VueCookies from "vue-cookies";

export default {
  components: { HeaderLogin },
  data() {
    return {
      visible: false,
      email: "",
      password: "",
      error: "", // Trường để lưu thông báo lỗi
    };
  },
  methods: {
    handleLogin() {
      const loginData = {
        email: this.email,
        password: this.password,
      };

      axios
        .post("https://localhost:7024/api/Login/dangnhap", loginData)
        .then((response) => {
          // Xử lý kết quả từ API ở đây (nếu thành công)
          VueCookies.set("jwtToken", response.data, "1d");
          // Chuyển trang khi đăng nhập thành công
          this.$router.push("/"); // Thay thế bằng đường dẫn trang chính của ứng dụng

          // Để hiển thị thông báo lỗi, ta gán giá trị null cho trường error
          // (nếu người dùng đã xử lý lỗi trước đó)
          this.error = null;
        })
        .catch((error) => {
          // Xử lý lỗi ở đây và hiển thị thông báo lỗi
          this.error = "Tài khoản hoặc mật khẩu không đúng.";
          console.error(error);
        });
    },
  },
};
</script>

<style scoped>
/* CSS để định dạng thông báo lỗi */
.error-message {
  margin-top: 8px;
  text-align: center;
  color: red;
}
</style>
