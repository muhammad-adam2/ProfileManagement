<template>
  <div class="update container">
      <h4 class="page-header">Update User Details</h4>
      <form>
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
      </form>
  </div>
</template>

<script>
export default {
  name: 'Update',
  data () {
    return {
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
