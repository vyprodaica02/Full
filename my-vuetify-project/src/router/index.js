import { createRouter, createWebHistory } from "vue-router";
import PhatTuComponent from "../components/PhatTuComponent.vue";
import CapNhatPhattu from "../components/CapNhatPhattu.vue";
import ComponentLogin from "../components/ComponentLogin.vue";
import ComponentRegister from "../components/ComponentRegister.vue";
import CompunentChua from "../components/CompunentChua.vue";
import DaoTrangComponent from "../components/DaoTrangComponent.vue";
import ComponentDonDangKy from "../components/ComponentDonDangKy.vue";
import ComponentThemChua from "../components/ComponentThemChua.vue";
const routes = [
  {
    path: "/",
    component: PhatTuComponent,
  },
  {
    path: "/CapNhatPhattu",
    component: CapNhatPhattu,
  },
  {
    path: "/ComponentLogin",
    component: ComponentLogin,
  },
  {
    path: "/ComponentRegister",
    component: ComponentRegister,
  },
  {
    path: "/CompunentChua",
    component: CompunentChua,
  },
  {
    path: "/DaoTrangComponent",
    component: DaoTrangComponent,
  },
  {
    path: "/ComponentDonDangKy",
    component: ComponentDonDangKy,
  },

  {
    path: "/ComponentThemChua",
    component: ComponentThemChua,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
