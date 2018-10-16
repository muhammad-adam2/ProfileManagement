<template>
  <div class="add container">
      <h4 class="page-header">New User</h4>
      <form v-on:submit="addUser">
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
            <label>Password:</label>
            <input type="text" class="form-control" placeholder="Password" v-model="user.password">
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
  name: 'Add',
  data () {
    return {
        user: {}
    }
  },
  methods: {
      addUser(e){
          if (!this.user.firstName || !this.user.lastName || !this.user.email || !this.user.password || !this.user.dob || !this.user.gender || !this.user.maritalStatus) {
              console.log("Please fill in required fields");
          } else {
              let newUser = {
                  firstName: this.user.firstName,
                  lastName: this.user.lastName,
                  email: this.user.email,
                  password: this.user.password,
                  dob: this.user.dob,
                  gender: this.user.gender,
                  maritalStatus: this.user.maritalStatus,
                  dom: this.user.dom,
              }
              console.log(newUser);
              this.$http.post("https://localhost:44328/api/User", newUser)
                .then(function(response){
                    this.$router.push({path: '/', query: {alert: 'New User Added'}});
                })
              e.preventDefault();
          }
          e.preventDefault();
      }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
