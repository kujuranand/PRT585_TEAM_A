import { applyMiddleware, combineReducers, compose } from "redux";
import thunk from "redux-thunk";
import { dCandidate } from "./dCandidate";
import { reducers } from "../resuders";


export const store = createStore (
    resuders,
    compose(
        applyMiddleware(thunk)
    )
)