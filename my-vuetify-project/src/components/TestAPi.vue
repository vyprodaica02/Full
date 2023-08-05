<template>
  <v-dialog v-model="selectDialogMorph" max-width="70%"><card-chua /></v-dialog>
  <v-dialog v-model="selectDialogDelete" max-width="70%"
    ><card-delete
  /></v-dialog>
  <v-row>
    <v-col cols="2">
      <v-combobox
        label="Hiển thị"
        density="compact"
        :items="['a', 'b']"
        variant="solo-inverted"
      />
    </v-col>
    <v-col cols="2">
      <v-combobox
        label="Sắp xếp"
        density="compact"
        :items="['a', 'b']"
        variant="plain"
      />
    </v-col>
    <v-col></v-col>
    <v-col cols="1">
      <v-btn color="primary" dark class="mb-2" @click="addItem()">
        New item
      </v-btn>
    </v-col>
  </v-row>
  <v-table>
    <thead>
      <tr class="bgTable">
        <th
          class="text-center"
          v-for="(item, index) in headersChua"
          :key="index"
        >
          {{ item }}
        </th>
      </tr>
    </thead>
    <tbody>
      <tr
        v-for="(item, index) in listChua"
        :key="index"
        :class="classTable(index)"
      >
        <td :class="classBottom(index, listChua.length - 1)">
          {{ item.tenChua }}
        </td>
        <td :class="classBottom(index, listChua.length - 1)">
          {{ item.ngayThanhLap }}
        </td>
        <td :class="classBottom(index, listChua.length - 1)">
          {{ item.diaChi }}
        </td>
        <td :class="classBottomAction(index, listChua.length - 1)">
          <v-btn
            size="small"
            icon
            style="background-color: #51c51a; color: #fff"
            height="30px"
            width="30px"
            @click="editItem(item, index)"
          >
            <v-icon>mdi-pencil</v-icon>
          </v-btn>
          &nbsp;
          <v-btn
            size="small"
            icon
            style="background-color: #51c51a; color: #fff"
            height="30px"
            width="30px"
            @click="deleteItem(item, index)"
          >
            <v-icon>mdi-delete</v-icon>
          </v-btn>
        </td>
      </tr>
    </tbody>
  </v-table>
</template>
<script>
import { inject } from "vue";
import CardChua from "../components/CardChua.vue";
import CardDelete from "./CardDelete.vue";
export default {
  setup() {
    const {
      dataChua,
      listChua,
      selectItem,
      selectIndex,
      selectDialogMorph,
      selectDialogDelete,
    } = inject("provides");
    return {
      dataChua,
      listChua,
      selectItem,
      selectIndex,
      selectDialogMorph,
      selectDialogDelete,
    };
  },
  components: {
    CardChua,
    CardDelete,
  },
  data: () => ({
    headersChua: ["Ten chua", "Ngay thanh lap", "Dia chi", "Actions"],
  }),
  methods: {
    addItem() {
      this.selectIndex = -1;
      this.selectItem = {};
      this.selectDialogMorph = true;
    },
    editItem(item, index) {
      this.selectItem = item;
      this.selectIndex = index;
      this.selectDialogMorph = true;
    },
    deleteItem(item, index) {
      this.selectItem = item;
      this.selectIndex = index;
      this.selectDialogDelete = true;
    },
    classTable(index) {
      if (index % 2 != 0) {
        return "bgTable";
      } else {
        return "";
      }
    },
    classBottom(index, length) {
      if (index === length) {
        return "borderBottom";
      } else {
        return "";
      }
    },
    classBottomAction(index, length) {
      if (index === length) {
        return "borderBottom text-center";
      } else {
        return "text-center";
      }
    },
  },
  created() {
    this.listChua = this.dataChua[0].data;
  },
};
</script>

<style scoped>
.bgTable {
  background-color: #f2f2f2;
}

.borderBottom {
  border-bottom: thin solid rgba(var(--v-border-color), var(--v-border-opacity));
}

th {
  border-top: thin solid rgba(var(--v-border-color), var(--v-border-opacity));
}

th:first-child,
td:first-child {
  border-left: thin solid rgba(var(--v-border-color), var(--v-border-opacity));
  border-right: thin solid rgba(var(--v-border-color), var(--v-border-opacity));
}

th:last-child,
td:last-child {
  border-right: thin solid rgba(var(--v-border-color), var(--v-border-opacity));
}

th:not(:first-child),
td:not(:first-child) {
  border-right: thin solid rgba(var(--v-border-color), var(--v-border-opacity));
}
</style>
