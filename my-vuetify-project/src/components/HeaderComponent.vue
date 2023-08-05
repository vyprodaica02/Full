<template>
  <div class="">
    <v-app-bar :elevation="3" class="px-10" app :height="60">
      <v-app-bar-nav-icon
        v-if="isAtctive == true"
        variant="text"
        @click="drawer = !drawer"
      ></v-app-bar-nav-icon>
      <div>
        <v-img src="../img/logo.png" :height="60" :width="60"></v-img>
      </div>
      <v-app-bar-title>
        <h1 class="color-primary text-h6">Lotus Academy</h1>
      </v-app-bar-title>
      <div class="user d-flex align-center">
        <div>
          <span class="text-h6">User</span>
        </div>
        <v-menu open-on-hover>
          <template v-slot:activator="{ props }">
            <v-btn color="primary" class="pa-0" v-bind="props">
              <v-icon class="user-logo"> mdi-monitor </v-icon>
            </v-btn>
          </template>
          <v-list>
            <v-list-item>
              <v-list-item-title>XXXX</v-list-item-title>
            </v-list-item>
          </v-list>
        </v-menu>
        <v-menu open-on-hover>
          <template v-slot:activator="{ props }">
            <v-btn color="primary" v-bind="props">
              <v-icon class="user-logo"> mdi-message </v-icon>
            </v-btn>
          </template>
          <v-list>
            <v-list-item>
              <v-list-item-title>XXXX</v-list-item-title>
            </v-list-item>
          </v-list>
        </v-menu>
        <v-menu open-on-hover>
          <template v-slot:activator="{ props }">
            <v-btn color="primary" v-bind="props">
              <v-icon class="user-logo">mdi-chevron-down</v-icon>
            </v-btn>
          </template>
          <v-list>
            <v-list-item>
              <v-list-item-title class="pointer" @click="handleLogout">
                Đăng xuất
              </v-list-item-title>
            </v-list-item>
          </v-list>
        </v-menu>
      </div>
    </v-app-bar>
    <v-container class="pa-0">
      <v-navigation-drawer permanent class="nav" theme="light" v-model="drawer">
        <v-expansion-panels>
          <v-expansion-panel
            v-for="item in items"
            :key="item.id"
            :title="item.title"
            :color="item.active === true ? 'red' : ''"
            @click="togglePanel(item)"
          >
            <v-expansion-panel-text
              v-for="child in item.childs"
              :key="child.id"
            >
              <!-- Nội dung của Expansion Panel Text -->
              <!-- Ví dụ: -->
              <router-link :to="child.route" class="router-link-custom">{{
                child.title
              }}</router-link>
            </v-expansion-panel-text>
          </v-expansion-panel>
        </v-expansion-panels>
      </v-navigation-drawer>
    </v-container>
  </div>
</template>

<script>
import Cookies from "js-cookie";
export default {
  data() {
    return {
      isAtctive: true,
      drawer: true,
      items: [
        {
          title: "Phật tử",
          icon: "mdi-account-circle",
          active: false,
          childs: [{ title: "Quản lý phật tử", route: "/" }],
        },
        {
          title: "Chùa",
          icon: "mdi-bank-plus",
          active: false,
          childs: [{ title: "Quản lý chùa", route: "/CompunentChua" }],
        },
        {
          title: "Đạo tràng",
          icon: "mdi-calendar-check",
          active: false,
          childs: [{ title: "Quản lý đạo tràng", route: "/DaoTrangComponent" }],
        },
        {
          title: "Đơn đăng ký",
          icon: "mdi-format-list-bulleted-square",
          active: false,
          childs: [
            { title: "Quản lý đơn đăng ký", route: "/ComponentDonDangKy" },
          ],
        },
      ],
    };
  },
  methods: {
    handleLogout() {
      Cookies.remove("jwtToken");

      // Chuyển hướng người dùng đến trang đăng nhập (ví dụ: "/ComponentLogin") sau khi xóa mã token
      this.$router.push("/ComponentLogin");
    },

    handleNavigation(route) {
      this.$router.push(route);
    },
    togglePanel(item) {
      // Nếu item.active là true (v-expansion-panel đã mở), đóng panel (gán item.active thành false)
      // Ngược lại, mở panel (gán item.active thành true) và đóng các panel khác (gán item.active của các panel khác thành false)
      if (item.active) {
        item.active = false;
      } else {
        this.items.forEach((otherItem) => {
          otherItem.active = false;
        });
        item.active = true;
      }
    },
  },
};
</script>

<style scoped>
.gapflex {
  gap: 15px;
}
.p-r {
  padding-right: 90px;
}
.user-logo {
  border-radius: 50%;
  width: 35px;
  height: 35px;
  font-size: 24px;
  color: orangered;
  background: #e4e4e4;
}
.router-link-custom {
  text-decoration: none; /* Loại bỏ underline */
  color: black; /* Đổi màu chữ thành màu xanh */
}
</style>
