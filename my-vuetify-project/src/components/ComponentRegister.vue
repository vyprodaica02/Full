<template>
  <div>
    <HeaderLogin />
    <v-form class="w-50 ma-auto mt-12 border rounded-lg pa-10">
      <h2 class="text-h5 text-center pb-5">ĐĂNG KÝ PHẬT TỬ</h2>
      <v-container>
        <div class="text-subtitle-1 text-medium-emphasis">Tên đăng nhập:</div>
        <v-text-field
          class="mt-3"
          density="compact"
          variant="solo"
        ></v-text-field>
        <div class="text-subtitle-1 text-medium-emphasis">Email:</div>
        <v-text-field
          class="mt-3"
          density="compact"
          variant="solo"
        ></v-text-field>
        <div class="text-subtitle-1 text-medium-emphasis">Password:</div>
        <v-text-field
          :append-inner-icon="visible1 ? 'mdi-eye-off' : 'mdi-eye'"
          :type="visible1 ? 'text' : 'password'"
          class="mt-3"
          density="compact"
          variant="solo"
          @click:append-inner="visible1 = !visible1"
        ></v-text-field>
        <div class="text-subtitle-1 text-medium-emphasis">
          Nhắc lại Password:
        </div>
        <v-text-field
          :append-inner-icon="visible ? 'mdi-eye-off' : 'mdi-eye'"
          :type="visible ? 'text' : 'password'"
          class="mt-3"
          density="compact"
          variant="solo"
          @click:append-inner="visible = !visible"
        ></v-text-field>
        <div class="text-subtitle-1 text-medium-emphasis">ngaysinh:</div>
        <v-text-field
          class="mt-3"
          density="compact"
          variant="solo"
          type="date"
        ></v-text-field>
        <v-btn
          block
          class="mb-8 input-btn bgs-primary"
          size="large"
          variant="tonal"
          @click="showAlert"
        >
          Đăng Ký
        </v-btn>
      </v-container>
    </v-form>
  </div>
</template>

<script>
import Swal from "sweetalert2/dist/sweetalert2.js";
import HeaderLogin from "./HeaderLogin";
export default {
  components: {
    HeaderLogin,
  },
  data: () => ({
    visible: false,
    visible1: false,
  }),
  methods: {
    showAlert() {
      // Save the component instance to access it inside the SweetAlert2 callback
      const vm = this;

      // Basic usage of SweetAlert2
      Swal.fire({
        title: "Bạn đã đăng ký thành công!",
        text: "Ấn vào đây để quay chở lại đăng nhâp!",
        icon: "success",
        confirmButtonText: "OK",
      }).then((result) => {
        if (result.isConfirmed) {
          // Redirect to another route when the "OK" button is clicked
          vm.$router.push("/ComponentLogin");
        }
      });
    },
  },
};
</script>

<style></style>
