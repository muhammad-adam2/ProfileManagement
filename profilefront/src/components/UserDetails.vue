<template>
  <div class="details container">
    <h4 class="page-header">User Details</h4>
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
