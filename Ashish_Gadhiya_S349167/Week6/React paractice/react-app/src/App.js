import logo from './logo.svg';
import './App.css';
import  {store} from "./actions/store";
import {provider} from "react-redux";
import DCandidates from './components/DCandidates';

function App() {
  return (
    <provider store={store}>
      <DCandidates />

    </provider>
  
  );
}

export default App;
