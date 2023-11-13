import { RouteRecord, Router, createRouter, createWebHistory } from 'vue-router'

class RouterBuilder {

    routes: RouteRecord[];

    history: any;

    constructor() {
        this.routes = [];
    }

    Add(path: string, component: string,name?: string): RouterBuilder
    {
        this.routes.push({
            path: path,
            name: name || path,
            redirect: '',
            components: { component: import(component) },
            children: [],
            meta: undefined,
            props: undefined,
            beforeEnter: undefined,
            leaveGuards: undefined,
            updateGuards: undefined,
            enterCallbacks: undefined,
            instances: undefined,
            aliasOf: undefined
        });
        return this;
    }

    UseWebHistory(): RouterBuilder {
        this.history = createWebHistory();
        return this;
    }


    Build(): Router {

        return createRouter({
            history: this.history,
            routes: this.routes 
        });
    }

}


const builder = new RouterBuilder();
builder.Add("/Login", "src/view/Login.vue");
