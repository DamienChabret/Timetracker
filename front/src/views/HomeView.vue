<script lang="ts">
    import BaseTitle from '@/components/BaseTitle.vue';
    import BaseButton from '@/components/BaseButton.vue';

    export default {
        name: 'HomeView',
        components: {
            BaseTitle,
            BaseButton
        }
    }
</script>

<template>
    <BaseTitle msg="bonjour"/>
    <BaseButton msg="clique pas"> </BaseButton>
</template>
  
<style>
</style>
  