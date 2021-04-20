import * as React from 'react';
import Input from '../input/input';
import './roomInput.css';

function RoomInput() {
  return (
    <Input
      type="text"
      classNameLabel="form-input-label"
      classNameField="form-input-field"
      text="Room name"
      placeholder="Enter room name"
      required={true}
    />
  );
}

export default RoomInput;
