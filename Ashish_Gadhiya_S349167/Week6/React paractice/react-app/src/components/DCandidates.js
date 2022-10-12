import React,{useState, useEffect} from "react";
import { Connect } from "react-redux";
import * as actions from "../actions/dCandidate";

const DCandidates = (props) => {
    //const [x,setx] = useState(0)
    //setx(5)

    useEffect(() => {
        props.fetchAllDCandidates()
    },[])

    return (<div>From DCandidate</div>);
}

const mapStateToProps = state => ({
    dCandidateList: state.dCandidate.list   
})

const mapActionToProps = {
    fetchAllDCandidates : actions.fetchall
}

export default connect(mapStateToProps,mapActionToProps)(DCandidates);
