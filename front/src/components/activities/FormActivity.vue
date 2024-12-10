<script lang="ts">
    import { defineComponent } from 'vue';
    import Time from '@/models/dto/Time';
    import BaseButton from '@/components/BaseButton.vue';

    export default defineComponent({
        name: 'YourComponentName',
        components: {
            BaseButton,
        },
        data() {
            return {
                hourBeginActivity: {
                    hours: null,
                    minutes: null,
                } as Time,
                hourEndActivity: {
                    hours: null,
                    minutes: null,
                } as Time,
            };
        },
        methods: {
            ValidateData(): void {
                const newObject = {
                    begin: this.hourBeginActivity,
                    end: this.hourEndActivity,
                };
                this.$emit('formValidate', newObject);
            },
        },
    });
</script>

<template>
    <div id="activityForm">
        <h2> Insérez vos dernières activités </h2>

        <!-- Heure de début-->
        <div>
            <p> Heure début </p>
            <input class="timeInput" id="startOfActivityHour" name="startOfActivityHour" type="number" min="0" max="24" v-model="hourBeginActivity.hours" required/>
            :
            <input class="timeInput" id="startOfActivityMinute" name="startOfActivityMinute" type="number" min="0" max="59" v-model="hourBeginActivity.minutes" required/>
        </div>

        <!-- Heure de fin-->
        <div>
            <p> Heure de fin </p>
            <input class="timeInput" id="endOfActivityHour" name="endOfActivityHour" type="number"  min="0" max="24" v-model="hourEndActivity.hours" required/>
            :
            <input class="timeInput" id="endOfActivityMinute" name="endOfActivityMinute" type="number" min="0" max="59" v-model="hourEndActivity.minutes" required/>
        </div>
        
        <BaseButton msg="Valider" @click="ValidateData"/>
    </div>
</template>

<style lang="css">
    #activityForm {
        background-color: #4e4444;
        color: white;

        width: 350px;
        height: auto;
        position: absolute;
        left: 50%;
        top: 50%;
        transform: translate(-50%, -50%);
        -webkit-transform: translate(-50%, -50%);
        padding: 1%;
    }

    .timeInput{
        height: 30px;
        width: 50px;
        font-size: 16.5px;
        -webkit-appearance: none;
        margin: 0;
        -moz-appearance: textfield;
    }
</style>