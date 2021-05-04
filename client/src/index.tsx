import React from 'react';
import ReactDOM from 'react-dom';
import { createStore } from 'redux';
import { composeWithDevTools } from 'redux-devtools-extension';
import { Provider } from 'react-redux';
import { Router } from 'react-router-dom';
import { createBrowserHistory } from 'history';
import App from './components/app/app';
import { reducer } from './store/reducer';

export const history = createBrowserHistory();

const store = createStore(
  reducer,
  composeWithDevTools()  
);

ReactDOM.render(
  <Provider store={store}>
    <Router history={history}>
      <App />
    </Router>,
  </Provider>,
    document.getElementById(`root`)
);
