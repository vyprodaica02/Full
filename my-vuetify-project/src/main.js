import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import vuetify from "./plugins/vuetify";
import { loadFonts } from "./plugins/webfontloader";
import "./css/style.css";
import VueSweetalert2 from "vue-sweetalert2";
import "sweetalert2/dist/sweetalert2.min.css";
import axios from "axios"; // Import Axios
import VueCookies from "vue-cookies";
import store from "./store"; // Import Vuex store

loadFonts();

const app = createApp(App);
app.use(router);
app.use(vuetify);
app.use(VueCookies);
app.use(VueSweetalert2);
app.use(store); // Use Vuex store

// Thiết lập cho Axios gửi kèm cookie trong mọi yêu cầu
axios.defaults.withCredentials = true;

app.mount("#app");
