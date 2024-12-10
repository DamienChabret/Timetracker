import { createApp, DirectiveBinding } from 'vue';
import App from './App.vue';
import router from './router/index';

// Déclaration de l'application Vue
const app = createApp(App);

// Directive personnalisée
app.directive('numeric-only', {
    // Le paramètre `el` doit être typé comme un élément HTML
    mounted(el: HTMLElement) {
        el.addEventListener('input', (event: Event) => {
            const target = event.target as HTMLInputElement;
            const value = target.value;
            target.value = value.replace(/[^0-9]/g, '');
            target.dispatchEvent(new Event('input'));
        });
    },
});

app.use(router).mount('#app');
