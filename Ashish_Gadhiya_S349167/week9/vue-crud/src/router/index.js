import { createRouter, createWebHistory } from 'vue-router'
import Main from '../pages/Main';
import Admin from '../pages/admin/Admin.vue'
import Students from '../pages/admin/Students.vue'
import StudentAdd from '../pages/admin/StudentAdd.vue'
import StudentEdit from '../pages/admin/StudentEdit.vue'

const routes = [
  {
    path: '/',
    name: 'Main',
    component: Main
  },
  {
    path: '/admin',
    name: 'Admin',
    component: Admin,
    children: [
      {
        path: 'students',
        name: 'Students',
        component: Students
      },
      {
        path: 'students/add',
        name: 'StudentAdd',
        component: StudentAdd
      },
      {
        path: 'students/:id/edit',
        name: 'StudentEdit',
        component: StudentEdit,
        props: true
      },
    ]
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
