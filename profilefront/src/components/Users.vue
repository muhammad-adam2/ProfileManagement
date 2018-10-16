<template>
  <div class="user container">
    <Alert v-if="alert" v-bind:message="alert" />
    <h4 class="page-header">All User Profiles</h4>
    <table class="table table-striped">
      <thead>
        <tr>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Email</th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="user in users" :key="user.id">
            <td>{{user.firstName}}</td>
            <td>{{user.lastName}}</td>
            <td>{{user.email}}</td>
            <td><router-link class="btn btn-primary" v-bind:to="'/user/' + user.id">View Details</router-link></td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import Alert from './Alert'
export default {
  name: 'Users',
  data () {
    return {
      users: [],
      alert: ''
    }
  },
  methods: {
    getUsers: function(){
      this.$http.get("https://localhost:44328/api/User")
      .then(function(response){
        this.users = response.body;
      });
    }
  },
  created: function(){
    if(this.$route.query.alert){
      this.alert = this.$route.query.alert;
    }
    this.getUsers();
  },
  updated: function(){
    this.getUsers();
  },
  components: {
    Alert
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
