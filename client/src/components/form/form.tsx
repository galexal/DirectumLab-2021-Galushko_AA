import React from 'react';
import Greeting from '../greeting/greeting';
import RegisterButton from '../registerButton/registerButton';

interface Props {
  text: string;
  classNameForm: string;
  classNameHeader: string;
  fields: [...any];
}

const Form: React.FC<Props> = ({
  text,
  classNameForm,
  classNameHeader,
  fields
}) => {
  return (
    <div className={classNameForm}>
      <Greeting/>
      <h2 className={classNameHeader}>{text}]</h2>
      {fields.map((field)=>(
        <div key={field}>{field}</div>
      ))}
      <RegisterButton/>
    </div>
  );
};

export default Form;
