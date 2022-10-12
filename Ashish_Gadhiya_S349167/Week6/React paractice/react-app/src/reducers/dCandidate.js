import { act } from "react-dom/test-utils";
import { ACTION_TYPES } from "../actions/DCandidate";
const initialstate = {
    list: []
}


export const dCandidate = (state = initialstate,action) => {
    switch (action.type) {
        case ACTION_TYPES.FETCH_ALL:
            return{
                ...state,
                list: [...action.payload]
            }
        default:
            return state
    }
}