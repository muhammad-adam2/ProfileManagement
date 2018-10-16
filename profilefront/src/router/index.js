import Vue from 'vue'
import Router from 'vue-router'
import vueResource from 'vue-resource'
import Users from '@/components/Users'
import Login from '@/components/Login'
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
      path: '/login',
      name: 'Login',
      component: Login
    },
    {
      path: '/user/:id',
      name: 'UserDetails',
      component: Details
    },
    {
      path: '/user/update/:id',
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
