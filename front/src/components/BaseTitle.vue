<script lang="ts">
    export default {
        name: 'BaseTitle',
        props: {
            msg: String
        }
    }
</script>

<template>
    <h1 class="home"> {{ msg }} </h1>
</template>

<style>
    .home {
        color: #4e4444;
    }
</style>
