<template>
  <div class="details container" v-on:submit="deleteUser">
    <h4 class="page-header">User Details</h4>
    <router-link class="btn" v-bind:to="'/'">Back</router-link>
    <table class="table table-striped">
      <thead>
        <tr>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Email</th>
          <th>Date of Birth</th>
          <th>Gender</th>
          <th>Marital Status</th>
          <th>Date of Marriage</th>
        </tr>
      </thead>
      <tbody>
        <tr>
            <td>{{user.firstName}}</td>
            <td>{{user.lastName}}</td>
            <td>{{user.email}}</td>
            <td>{{user.dob}}</td>
            <td>{{user.gender}}</td>
            <td>{{user.maritalStatus}}</td>
            <td>{{user.dom}}</td>
        </tr>
      </tbody>
    </table>
    <router-link class="btn" v-bind:to="'/user/update/' + user.id">Update Details</router-link>
    <button class="btn btn-danger" v-on:click="deleteUser(user.id)">Delete</button>
  </div>
</template>

<script>
export default {
  name: 'UserDetails',
  data () {
    return {
      user: ''
    }
  },
  methods: {
    fetchUser(id){
      this.$http.get("https://localhost:44328/api/User/" + id)
      .then(function(response){
        this.user = response.body;
      });  
    },
    deleteUser(id){
      this.$http.delete("https://localhost:44328/api/User/" + this.$route.params.id)
      .then(function(response){
        this.$router.push({path: '/', query: {alert: 'User Deleted'}});
      });
    }
  },
  created: function() {
    this.fetchUser(this.$route.params.id);
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
