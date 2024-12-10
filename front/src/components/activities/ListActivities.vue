<script>
import { reactive } from 'vue';
import ActivityRepository from '@/models/Repositories/ActivityRepository';
import TimePassedRepository from '@/models/Repositories/TimePassedRepository';
import TheActivity from '@/components/activities/TheActivity.vue';

export default {
    name: 'ListActivities',
    components: {
        TheActivity,
    },
    data() {
        const activityRepo = new ActivityRepository();
        const timePassedRepo = new TimePassedRepository();

        // Crée un objet réactif à partir des activités chargées
        const activities = reactive({
            list: [],
        });

        async () => {
            this.loadActivities();
        };

        return {
            activities,
            TimePassed: timePassedRepo.totalTime,
            activityRepo,
            timePassedRepo,
        };
    },
    mounted() {
        this.loadActivities();
    },
    computed: {
        totalTime() {
            return this.activityRepo.totalTimeActivity();
        },
    },
    methods: {
        async loadActivities() {
            await this.activityRepo.getAllActivities(); // Chargez les activités
            this.activities.list = this.activityRepo.listActivities; // Mettez à jour la liste ici
        },
        async updateActivity(e) {
            this.timePassedRepo.add(e.begin, e.end, new Date(), e.idActivity);
            this.activities.list = this.activityRepo.listActivities; // Mettez à jour la liste ici
        },
    },
};
</script>

<template>
    <div>
        <p v-if="this.activityRepo.totalTimeActivity() != null">
            Temps passé total : {{ this.activityRepo.totalTimeActivity().hours }} heures {{ this.activityRepo.totalTimeActivity().minutes }} minutes
        </p>
        <p v-else> Aucun temps passé pour le moment </p>
        <ul id="listActivities">
            <li v-for="item in activities.list" :key="item.id">
                <TheActivity @updateActivity="updateActivity" :activity="item" />
            </li>
        </ul>
    </div>
</template>

<style>
    #listActivities {
        display: flex;
        flex-wrap: wrap;
        gap: 20px;
        list-style-type: none;
    }
</style>
