
import './App.css';
import {Home} from './Home.js';
import {Student} from './Student.js';
import {Course} from './Course.js'
import {BrowserRouter, Route, Switch, NavLink} from 'react-router-dom'


function App() {
  return (
    <BrowserRouter>
    <div className="App container">
      <h3 className='d-flex justify-content-center m-3'>
        React JS FrontEnd
      </h3>
      <nav className='navbar navbar-expand-sm bg-light navbar-dark'>
        <ul className='navbar-nav'>
          <li className='nav-item- m-1'>
            <NavLink className="btn btn-light btn-outline-primary" to="/home">Home</NavLink>
          </li>
          <li className='nav-item- m-1'>
            <NavLink className="btn btn-light btn-outline-primary" to="/student">Student</NavLink>
          </li>
          <li className='nav-item- m-1'>
            <NavLink className="btn btn-light btn-outline-primary" to="/course">Course</NavLink>
          </li>
        </ul>
      </nav>
      <Switch>
        <Route path='/home' component={Home}/>
        <Route path='/student' component={Student}/>
        <Route path='/course' component={Course}/>
      </Switch>
    </div>
    </BrowserRouter>
  );
}

export default App;
