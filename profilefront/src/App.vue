<template>
  <div id="app">
    <h1>Profile Management</h1>
      <nav class="navbar navbar-expand-md navbar-light bg-light fixed-top">
      <router-link class="navbar-brand" to="/">Profile Management</router-link>
      <div class="collapse navbar-collapse" id="navbarsExampleDefault">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <router-link class="nav-link" to="/">Home <span class="sr-only">(current)</span></router-link>
          </li>
        </ul>
        <ul class="navbar-nav navbar-right ">
          <li class="nav-item active">
            <router-link class="nav-link" to="/new">Register</router-link>
          </li>
          <li class="nav-item active">
            <router-link class="nav-link" to="/login">Login</router-link>
          </li>
        </ul>
      </div>
    </nav>
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>

</style>
