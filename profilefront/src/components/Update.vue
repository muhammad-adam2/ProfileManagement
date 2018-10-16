<template>
  <div class="update container">
      <h4 class="page-header">Update User Details</h4>
      <form v-on:submit="updateUser">
        <div class="well">
          <div class="form-group">
            <label>First Name:</label>
            <input type="text" class="form-control" placeholder="First Name" v-model="user.firstName">
          </div>
          <div class="form-group">
            <label>Last Name:</label>
            <input type="text" class="form-control" placeholder="Last Name" v-model="user.lastName">
          </div>
          <div class="form-group">
            <label>Email:</label>
            <input type="text" class="form-control" placeholder="Email Address" v-model="user.email">
          </div>
          <div class="form-group">
            <label>Date of Birth:</label>
            <input type="text" class="form-control" placeholder="DD/MM/YYYY" v-model="user.dob">
          </div>
          <div class="form-group">
            <label>Gender:</label>
            <input type="text" class="form-control" placeholder="Gender" v-model="user.gender">
          </div>
          <div class="form-group">
            <label>Marital Status:</label>
            <input type="text" class="form-control" placeholder="Marital Status" v-model="user.maritalStatus">
          </div>
          <div class="form-group">
            <label>Date of Marriage:</label>
            <input type="text" class="form-control" placeholder="DD/MM/YYYY" v-model="user.dom">
          </div>
        </div>
        <button type="submit" class="btn">Submit</button>
      </form>
  </div>
</template>

<script>
export default {
  name: 'Update',
  data () {
    return {
      user: {}
    }
  },
  methods: {
      fetchUser(id){
      this.$http.get("https://localhost:44328/api/User/" + id)
      .then(function(response){
        this.user = response.body;
      }); 
      },
      updateUser(e){
          if (!this.user.firstName || !this.user.lastName || !this.user.email || !this.user.dom || !this.user.dob || !this.user.gender || !this.user.maritalStatus) {
              console.log("Please fill in required fields");
          } else {
              let updUser = {
                  firstName: this.user.firstName,
                  lastName: this.user.lastName,
                  email: this.user.email,
                  dob: this.user.dob,
                  gender: this.user.gender,
                  maritalStatus: this.user.maritalStatus,
                  dom: this.user.dom,
              }
              console.log(updUser);
              this.$http.put("https://localhost:44328/api/User/" + this.$route.params.id, updUser)
                .then(function(response){
                    this.$router.push({path: '/', query: {alert: 'User Updated'}});
                })
              e.preventDefault();
          }
          e.preventDefault();
      }
  },
  created: function(){
    this.fetchUser(this.$route.params.id)
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
