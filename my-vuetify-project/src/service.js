// service.js

import axios from "axios";

const apiClient = axios.create({
  baseURL: "https://localhost:7024/api", // Địa chỉ URL cơ sở của API
  headers: {
    "Content-Type": "application/json",
    // Các header khác bạn muốn sử dụng (nếu có)
  },
});

export default {
  async layAllDanhSachDaoTrang() {
    try {
      const response = await apiClient.get("/DaoTrang/layAllDanhSachDaoTrang");
      return response.data;
    } catch (error) {
      console.error("Error while calling API:", error);
      throw error; // Rethrow the error if needed
    }
  },
};
