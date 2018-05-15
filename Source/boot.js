import Vue from "vue";
import Index from "./Components/Home/Index.vue"

import "bootstrap";

var root = new Vue({
    el: "#root",
    template: "<index/>",
    components: {
        Index
    }
})