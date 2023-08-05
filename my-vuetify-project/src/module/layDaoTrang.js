// layDaoTrang.js
import axios from "axios";

export default {
  actions: {
    layDanhSachDaoTrang({ commit }) {
      // Gọi API để lấy danh sách đảo trang
      axios
        .get("https://localhost:7024/api/DaoTrang/layAllDanhSachDaoTrang")
        .then((response) => {
          // Gọi mutation để lưu danh sách đảo trang vào state
          commit("SET_DANH_SACH_DAO_TRANG", response.data);
        })
        .catch((error) => {
          console.error("Lỗi khi lấy danh sách đảo trang:", error);
        });
    },
  },
};
