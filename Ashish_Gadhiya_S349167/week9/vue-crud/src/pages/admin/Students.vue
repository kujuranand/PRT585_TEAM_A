<template>
  <router-link :to="{ name: 'StudentAdd'}" class="btn">Add Student</router-link>
    <table>
      <thead>
        <tr>
          <th>Id</th>
          <th>Name</th>
          <th>Email</th>
          <th>Phone</th>
          <th>Course</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="student in students" :key="student.id">
          <td>{{student.id}}</td>
          <td>{{student.name}}</td>
          <td>{{student.email}}</td>
          <td>{{student.phone}}</td>
          <td>{{student.course}}</td>

          <!-- <td>{{student.title}}</td>
          <td><img :src="student.image" :alt="student.title" width="90" /></td> -->
          <td>
            <router-link :to="{ name: 'StudentEdit', params: { id: student.id }}" class="btn">Edit</router-link>
            <button @click="del(student.id)" class="btn btn-del">Delete</button>
          </td>
        </tr>
      </tbody>
    </table>
  </template>
  
  <script>
  import {onMounted, ref} from 'vue';
  
  export default {
    name: 'Students',
    setup() {
      const students = ref([]);
  
      onMounted( async () => {
        const res = await fetch('http://localhost:3000/students');
  
        students.value = await res.json();
      })
  
      const del = async (id) => {
        await fetch(`http://localhost:3000/students/${id}`, {
          method: 'DELETE'
        })
  
        students.value = students.value.filter(p => p.id !== id);
      }
  
      return { students, del }
    }
  }
  </script>
  