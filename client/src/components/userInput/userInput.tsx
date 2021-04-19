import * as React from 'react';
import './userInput.css';

function UserInput() {
  return (
    <div className="user-name">
      <label htmlFor="user-name">User name</label>
      <input className="user-name__field" type="text" name="userName" id="userName" placeholder="Enter your name" required/>
    </div>
  );
}

export default UserInput;
