<script lang="ts">
    export default {
        name: 'BaseButton',
        props: {
            msg: String
        }
    }
</script>

<template>
    <button class="baseButton"> {{ msg }} </button>
</template>

<style>
    .baseButton {
        text-decoration: none;
        border: none;
        color: #4e4444;
        background-color: #ffffff;
        border-color: #4e4444;
        border-radius: 3%;
        border-style: initial;
        height: 40px;
        width: 150px;
        margin: 1%;
    }

    .baseButton:hover {
        background-color: #e9e9e9;
        transition:all();
    }
</style>
