import React from 'react';

interface Props {
  text: string;
  placeholder: string;
  type: 'text' | undefined;
  classNameLabel: string;
  classNameField: string;
  required: boolean;
}

const Input: React.FC<Props> = ({
  text,
  placeholder,
  type,
  classNameLabel,
  classNameField,
  required
}) => {
  return (
    <div className={classNameLabel}>
      <label htmlFor={classNameLabel}>{text}</label>
      <input className={classNameField} type={type} placeholder={placeholder} required={required}/>
    </div>
  );
};

export default Input;
