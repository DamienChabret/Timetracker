<script>
    import Activity from '@/models/dto/Activity';

    export default {
        name: 'TheActivity',
        components: {
            Activity,
        },
        props: {
           activity: Activity,
        },
        data() {
            return{
               addEntry : false,
            }
        },
        methods:{
            addNewEntry() {
                addEntry = true;
            },
        }
    }
</script>

<template>
    <div id="activityDetails">
        <h3> {{ activity.name }} </h3>
        <p> {{ activity.description }} </p>

        <div id="activityTimeDetails">
            <table>
                <!-- en tête -->
                <thead>
                    <tr>
                        <th scope="col"> Date </th>
                        <th scope="col"> Début </th>
                        <th scope="col"> Fin </th>
                    </tr>
                </thead>
                <!-- corp -->
                <tbody>
                    <tr v-if="!addEntry"><td rowspan="3" @click="addNewEntry"> + </td></tr>
                    <tr v-elfe>
                        <td> <date> </date> </td> <!-- Date picker -->
                        <td> <input/> <input/> </td> <!-- heure de début -->
                        <td> <input/> <input/> </td> <!-- heure de fin -->
                    </tr>

                    <tr v-for="item in activity.timePassed" :key="item.date">
                        <td> {{item.date}} </td>
                        <td> {{item.begin.hours}}:{{item.begin.minutes}} </td>
                        <td> {{item.end.hours}}:{{item.end.minutes}} </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<style lang="css">
    #activityDetails{
        
    }
</style>