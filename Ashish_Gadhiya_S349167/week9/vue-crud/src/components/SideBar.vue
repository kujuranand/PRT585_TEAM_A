<template>
    <div class="sidebar">
      <ul class="side-menu">
          <li><router-link :to="{ name: 'Students'}">Student List</router-link></li>
          <li><router-link :to="{ name: 'StudentAdd'}">Add Student</router-link></li>
      </ul>
  </div>
  </template>

<script>
export default {
    name: 'SideBar'

}
</script>

<style>

</style>