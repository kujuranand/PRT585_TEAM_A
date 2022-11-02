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
       
        <button>Save</button>
  </form>
  </template>
  
  <script>
  import { onMounted, ref } from 'vue'
  import { useRouter, useRoute } from 'vue-router'
  
  export default {
      name: "StudentEdit",
      props: ['id'],
      setup() {
         const name = ref('');
         const email = ref(''); 
         const phone = ref('');
         const course = ref('');
         const router = useRouter();
         const route = useRoute()
         onMounted(async() => {
             const res = await fetch(`http://localhost:3000/students/${route.params.id}`);
             const student = await res.json();
             name.value = student.name;
             email.value = student.email;
             phone.value = student.phone;
             course.value = student.course;

         })
  
         const submit = async () => {
             await fetch(`http://localhost:3000/students/${route.params.id}`, {
                 method: 'PUT',
                 headers: {"Content-type": "application/json"},
                 body: JSON.stringify({ 
                     name: name.value,
                     email: email.value,
                     phone: phone.value,
                     course: course.value,

                  })
             });
  
             await router.push('/admin/students');
         }
         
         return {name, email, phone, course, submit}
      }
      
  }
  </script>
  