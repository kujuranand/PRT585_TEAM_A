import { createStoreHook } from "react-redux";
import thunk from "redux-thunk";
import { applyMiddleware, compose } from "redux";

export const store = createStoreHook(
    {},
    compose(
        applyMiddleware(thunk)
    )
)