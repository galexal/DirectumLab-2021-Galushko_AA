import * as React from 'react';

interface Props {
  className: string;
}

const Main: React.FC<Props> = ({
  className,
  children
}) => {
  return (
    <div className={className}>
      {
        children
      }
    </div>
  );
};

export default Main;
