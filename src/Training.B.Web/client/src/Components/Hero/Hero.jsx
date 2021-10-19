import React from 'react';

const Hero = props => {

    const renderHtml = (rawHtml) => React.createElement("div", { dangerouslySetInnerHTML: { __html: rawHtml } });

    return (
        <div className="row justify-content-center">
            <div className="col-10 text-center"
                style={{
                    padding: "10px",
                    margin: "10px",
                    border: "1px dashed blue",
                    background: "url(" + props.backgroundUrl + ")",
                    minHeight: 400,
                    color: "white"
                }}>
                <h1 data-epi-property-name={props.headingName}>{props.heading}</h1>
                <div data-epi-property-name={props.bodyName}>{renderHtml(props.body)}</div>
            </div>
        </div>
    );
};

export default Hero;