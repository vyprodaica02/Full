// store.js
import Vuex from "vuex";
import layDaoTrangModule from "./module/layDaoTrang"; // Update the module import name
import axios from "axios";

const store = new Vuex.Store({
  state: {
    danhSachDaoTrang: [],
  },
  mutations: {
    SET_DANH_SACH_DAO_TRANG(state, danhSach) {
      state.danhSachDaoTrang = danhSach;
    },
  },
  actions: {
    saveChanges({ commit }, editedData) {
      // Gửi dữ liệu đã chỉnh sửa lên API
      // return axios
      //   .post("https://localhost:7024/api/DaoTrang/SuaDaotrang", editedData)
      //   .then((response) => {
      //     // Gọi mutation để cập nhật dữ liệu trong Vuex store
      //     commit("SET_DANH_SACH_DAO_TRANG", response.data);
      //   });
    },
    ...layDaoTrangModule.actions, // Update the actions import
  },
  getters: {
    daoTrangData: (state) => state.danhSachDaoTrang,
  },
});

export default store;
