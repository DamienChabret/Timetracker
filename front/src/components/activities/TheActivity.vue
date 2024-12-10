<script>
    import Activity from '@/models/dto/Activity';
    import FormActivity from '@/components/activities/FormActivity.vue';
    import BaseButton from '@/components//BaseButton.vue';

    export default {
        name: 'TheActivity',
        components: {
            FormActivity,
            BaseButton
        },
        props: {
            activity : Activity,
        },
        data() {
            console.log(this.activity);
            return{
                hours: 0,
                minutes: 0,
                shouldDisplayActivityForm : false
            }
        },
        methods:{
            DisplayActivityForm() {
                this.shouldDisplayActivityForm = true;
            },

            UpdateActivity(e) {
                this.shouldDisplayActivityForm = false
                const newObject = {
                    begin : e.begin,
                    end : e.end,
                    idActivity : this.activity.id,
                }
                this.$emit("updateActivity", newObject)
            }
        }
    }
</script>

<template>
    <div class="activity">
        <h1> {{ activity.name }} </h1>
        <p> {{ activity.description }} </p>
        <p> {{ activity.TotalTime.hours }} heures et {{ activity.TotalTime.minutes }} minutes passées </p>
        <BaseButton msg="Nouvelle entrée" @click="DisplayActivityForm"></BaseButton> 
    </div>

    <!-- Formulaire du temps passé-->
    <div v-if="shouldDisplayActivityForm" id="blackScreen"></div>
    <div v-if="shouldDisplayActivityForm">
        <FormActivity @formValidate="UpdateActivity"></FormActivity>
    </div>
</template>

<style lang="css">
    .activity {
        background-color: #4e4444;
        border-color: black;
        border-radius: 1%;
        color: white;
        width: 300px;
        padding: 0.1%;
        margin: 1%;
    }

    #blackScreen{
        position: fixed;
        top: 0;
        left: 0;
        width: 100vw;
        height: 100vh;
        background-color: rgba(0, 0, 0, 0.5);
        pointer-events: auto;
    }
</style>