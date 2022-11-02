<template>
    <form @submit.prevent="submit" >
      <label>Name</label>
      <input type="text" name="name" v-model="name" required/>
      <label>Email</label>
      <input type="text" name="email" v-model="email" required/>
      <label>Phone</label>
      <input type="number" name="phone" v-model="phone" required/>
      <label>Course</label>
      <input type="text" name="course" v-model="course" required/>
      <button>Add Student</button>
  </form>
  </template>
<script>
import { ref } from 'vue'
import { useRouter } from 'vue-router'

export default {
    name: "StudentAdd",
    setup() {
       const name = ref(''); 
       const email = ref('');
       const phone = ref('');
       const course = ref('');
       const router = useRouter();

       const submit = async () => {
           await fetch('http://localhost:3000/students', {
               method: 'POST',
               headers: {"Content-type": "application/json"},
               body: JSON.stringify({ 
                   name: name.value,
                   email: email.value,
                   phone: phone.value,
                   course: course.value
                })
           });

           await router.push('/admin/students');
       }
       
       return {name, email, phone, course, submit}
    }
    
}
</script>

<style>

</style>