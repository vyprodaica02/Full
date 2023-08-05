<template>
  <div>
    <Myproject />
  </div>
</template>

<script>
import { defineComponent } from "vue";

// Components
import HeaderComponent from "./HeaderComponent.vue";

export default defineComponent({
  components: {
    Myproject,
  },
});
</script>
