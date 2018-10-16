import Vue from 'vue'
import Router from 'vue-router'
import vueResource from 'vue-resource'
import Users from '@/components/Users'
import About from '@/components/About'
import Details from '@/components/UserDetails'
import Update from '@/components/Update'
import Add from '@/components/Add'

Vue.use(Router)
Vue.use(vueResource)

export default new Router({
  mode: 'history',
  base: __dirname,
  routes: [
    {
      path: '/',
      name: 'Users',
      component: Users
    },
    {
      path: '/about',
      name: 'About',
      component: About
    },
    {
      path: '/user/:id',
      name: 'UserDetails',
      component: Details
    },
    {
      path: '/user/update',
      name: 'Update',
      component: Update
    },
    {
      path: '/new',
      name: 'Add',
      component: Add
    }
  ]
})
