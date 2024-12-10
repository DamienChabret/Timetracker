<script lang="ts">
    import BaseTitle from '@/components/BaseTitle.vue';
    import BaseButton from '@/components/BaseButton.vue';

    export default {
        name: 'App',
        components: {
            BaseTitle,
            BaseButton
        }
    }
</script>

<template>
    <BaseTitle msg="help"/>
    <BaseButton msg="clique"> </BaseButton>
</template>
  
<style>
</style>
  