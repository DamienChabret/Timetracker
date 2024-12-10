import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router';
import HomeView from '../views/HomeView.vue';
import ActivitiesView from '../views/ActivitiesView.vue';
import HelpView from '../views/HelpView.vue';


// Typage des routes
const routes: RouteRecordRaw[] = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/activities',
    name: 'activities', // Changement de nom pour éviter les doublons
    component: ActivitiesView
  },
  {
    path: '/about',
    name: 'about',
    component: HelpView
  }
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
});

export default router;
