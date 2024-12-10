<script lang="ts">
  import ListActivities from '@/components/activities/ListActivities.vue';
  import BaseTitle from '@/components/BaseTitle.vue';

  export default {
    name: 'App',
    components: {
      BaseTitle,
      ListActivities
    }
  }
</script>

<template>
    <BaseTitle msg="Liste activitées"/>
    <ListActivities></ListActivities>
</template>

<style>
</style>
  