<template>
  <v-app>
    <v-main>
      <HeaderComponent v-if="shouldShowHeader" />
      <router-view />
    </v-main>
  </v-app>
</template>

<script>
import HeaderComponent from "./components/HeaderComponent";
export default {
  name: "App",
  components: {
    HeaderComponent,
  },
  data: () => ({
    //
  }),
  // ẩn header khi vào trang không muốn hiện
  computed: {
    isComponentLogin() {
      return this.$route.path === "/ComponentLogin";
    },
    isComponentRegister() {
      return this.$route.path === "/ComponentRegister";
    },

    shouldShowHeader() {
      return !this.isComponentLogin && !this.isComponentRegister;
    },
  },
};
</script>
