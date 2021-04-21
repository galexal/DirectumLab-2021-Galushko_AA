import React from 'react';
import Greeting from '../greeting/greeting';
import RegisterButton from '../button/registerButton';

interface Props {
  text: string;
  classNameForm: string;
  classNameHeader: string;
  fields: Array<React.ReactElement>;
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
      <h2 className={classNameHeader}>{text}</h2>
      {fields.map((field)=>(
        <div key={field.key}>{field}</div>
      ))}
      <RegisterButton/>
    </div>
  );
};

export default Form;
