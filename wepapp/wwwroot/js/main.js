
(function ($) {
  // USE STRICT
  "use strict";

  try {

    // Recent Report
    const brandProduct = 'rgba(0,181,233,0.8)'
    const brandService = 'rgba(0,173,95,0.8)'

    var elements = 10
    var data1 = [52, 60, 55, 50, 65, 80, 57, 70, 105, 115]
    var data2 = [102, 70, 80, 100, 56, 53, 80, 75, 65, 90]

    var ctx = document.getElementById("recent-rep-chart");
    if (ctx) {
      ctx.height = 250;
      var myChart = new Chart(ctx, {
        type: 'line',
        data: {
          labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', ''],
          datasets: [
            {
              label: 'My First dataset',
              backgroundColor: brandService,
              borderColor: 'transparent',
              pointHoverBackgroundColor: '#fff',
              borderWidth: 0,
              data: data1

            },
            {
              label: 'My Second dataset',
              backgroundColor: brandProduct,
              borderColor: 'transparent',
              pointHoverBackgroundColor: '#fff',
              borderWidth: 0,
              data: data2

            }
          ]
        },
        options: {
          maintainAspectRatio: true,
          legend: {
            display: false
          },
          responsive: true,
          scales: {
            xAxes: [{
              gridLines: {
                drawOnChartArea: true,
                color: '#f2f2f2'
              },
              ticks: {
                fontFamily: "Arial",
                fontSize: 12
              }
            }],
            yAxes: [{
              ticks: {
                beginAtZero: true,
                maxTicksLimit: 5,
                stepSize: 50,
                max: 150,
                fontFamily: "Arial",
                fontSize: 12
              },
              gridLines: {
                display: true,
                color: '#f2f2f2'

              }
            }]
          },
          elements: {
            point: {
              radius: 0,
              hitRadius: 10,
              hoverRadius: 4,
              hoverBorderWidth: 3
            }
          }


        }
      });
    }

    // Percent Chart
    var ctx = document.getElementById("percent-chart");
    if (ctx) {
      ctx.height = 280;
        var myChart = new Chart(ctx, {
            type: 'doughnut',
            data: {
                datasets: [
                    {
                        label: "Đơn hàng",
                        data: [40, 30, 25, 5],
                        backgroundColor: ['#00b5e9', '#fa4251', '#216C53', '#EA4B33'],
              hoverBackgroundColor: [
                '#00b5e9',
                  '#fa4251', '#216C53', '#EA4B33'
              ],
              borderWidth: [
                0, 0
              ],
              hoverBorderColor: [
                'transparent',
                  'transparent', 'transparent', 'transparent'
              ]
            }
          ],
          labels: [
            'Hoàn tất',
            'Xử lý', 'Đang giao', 'Đơn hủy'
          ]
        },
        options: {
          maintainAspectRatio: false,
          responsive: true,
          cutoutPercentage: 55,
          animation: {
            animateScale: true,
            animateRotate: true
          },
          legend: {
            display: false
          },
          tooltips: {
            titleFontFamily: "Arial",
            xPadding: 15,
            yPadding: 10,
            caretPadding: 0,
            bodyFontSize: 16
          }
        }
      });
    }

  } catch (error) {
    console.log(error);
  }



  try {

    // Recent Report 2
    const bd_brandProduct2 = 'rgba(0,181,233,0.9)'
    const bd_brandService2 = 'rgba(0,173,95,0.9)'
    const brandProduct2 = 'rgba(0,181,233,0.2)'
    const brandService2 = 'rgba(0,173,95,0.2)'

    var data3 = [52, 60, 55, 50, 65, 80, 57, 70, 105, 115]
    var data4 = [102, 70, 80, 100, 56, 53, 80, 75, 65, 90]

    var ctx = document.getElementById("recent-rep2-chart");
    if (ctx) {
      ctx.height = 230;
      var myChart = new Chart(ctx, {
        type: 'line',
        data: {
          labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', ''],
          datasets: [
            {
              label: 'My First dataset',
              backgroundColor: brandService2,
              borderColor: bd_brandService2,
              pointHoverBackgroundColor: '#fff',
              borderWidth: 0,
              data: data3

            },
            {
              label: 'My Second dataset',
              backgroundColor: brandProduct2,
              borderColor: bd_brandProduct2,
              pointHoverBackgroundColor: '#fff',
              borderWidth: 0,
              data: data4

            }
          ]
        },
        options: {
          maintainAspectRatio: true,
          legend: {
            display: false
          },
          responsive: true,
          scales: {
            xAxes: [{
              gridLines: {
                drawOnChartArea: true,
                color: '#f2f2f2'
              },
              ticks: {
                fontFamily: "Arial",
                fontSize: 12
              }
            }],
            yAxes: [{
              ticks: {
                beginAtZero: true,
                maxTicksLimit: 5,
                stepSize: 50,
                max: 150,
                fontFamily: "Arial",
                fontSize: 12
              },
              gridLines: {
                display: true,
                color: '#f2f2f2'

              }
            }]
          },
          elements: {
            point: {
              radius: 0,
              hitRadius: 10,
              hoverRadius: 4,
              hoverBorderWidth: 3
            },
            line: {
              tension: 0
            }
          }


        }
      });
    }

  } catch (error) {
    console.log(error);
  }


  try {

    // Recent Report 3
    const bd_brandProduct3 = 'rgba(0,181,233,0.9)';
    const bd_brandService3 = 'rgba(0,173,95,0.9)';
    const brandProduct3 = 'transparent';
    const brandService3 = 'transparent';

    var data5 = [52, 60, 55, 50, 65, 80, 57, 115];
    var data6 = [102, 70, 80, 100, 56, 53, 80, 90];

    var ctx = document.getElementById("recent-rep3-chart");
    if (ctx) {
      ctx.height = 230;
      var myChart = new Chart(ctx, {
        type: 'line',
        data: {
          labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July', ''],
          datasets: [
            {
              label: 'My First dataset',
              backgroundColor: brandService3,
              borderColor: bd_brandService3,
              pointHoverBackgroundColor: '#fff',
              borderWidth: 0,
              data: data5,
              pointBackgroundColor: bd_brandService3
            },
            {
              label: 'My Second dataset',
              backgroundColor: brandProduct3,
              borderColor: bd_brandProduct3,
              pointHoverBackgroundColor: '#fff',
              borderWidth: 0,
              data: data6,
              pointBackgroundColor: bd_brandProduct3

            }
          ]
        },
        options: {
          maintainAspectRatio: false,
          legend: {
            display: false
          },
          responsive: true,
          scales: {
            xAxes: [{
              gridLines: {
                drawOnChartArea: true,
                color: '#f2f2f2'
              },
              ticks: {
                fontFamily: "Arial",
                fontSize: 12
              }
            }],
            yAxes: [{
              ticks: {
                beginAtZero: true,
                maxTicksLimit: 5,
                stepSize: 50,
                max: 150,
                fontFamily: "Arial",
                fontSize: 12
              },
              gridLines: {
                display: false,
                color: '#f2f2f2'
              }
            }]
          },
          elements: {
            point: {
              radius: 3,
              hoverRadius: 4,
              hoverBorderWidth: 3,
              backgroundColor: '#333'
            }
          }


        }
      });
    }

  } catch (error) {
    console.log(error);
  }

  try {
    //WidgetChart 5
    var ctx = document.getElementById("widgetChart5");
    if (ctx) {
      ctx.height = 220;
      var myChart = new Chart(ctx, {
        type: 'bar',
        data: {
          labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],
          datasets: [
            {
              label: "My First dataset",
              data: [78, 81, 80, 64, 65, 80, 70, 75, 67, 85, 66, 68],
              borderColor: "transparent",
              borderWidth: "0",
              backgroundColor: "#ccc",
            }
          ]
        },
        options: {
          maintainAspectRatio: true,
          legend: {
            display: false
          },
          scales: {
            xAxes: [{
              display: false,
              categoryPercentage: 1,
              barPercentage: 0.65
            }],
            yAxes: [{
              display: false
            }]
          }
        }
      });
    }

  } catch (error) {
    console.log(error);
  }

  try {

    // Percent Chart 2
    var ctx = document.getElementById("percent-chart2");
    if (ctx) {
      ctx.height = 209;
      var myChart = new Chart(ctx, {
        type: 'doughnut',
        data: {
          datasets: [
            {
              label: "My First dataset",
              data: [60, 40],
              backgroundColor: [
                '#00b5e9',
                '#fa4251'
              ],
              hoverBackgroundColor: [
                '#00b5e9',
                '#fa4251'
              ],
              borderWidth: [
                0, 0
              ],
              hoverBorderColor: [
                'transparent',
                'transparent'
              ]
            }
          ],
          labels: [
            'Products',
            'Services'
          ]
        },
        options: {
          maintainAspectRatio: false,
          responsive: true,
          cutoutPercentage: 87,
          animation: {
            animateScale: true,
            animateRotate: true
          },
          legend: {
            display: false,
            position: 'bottom',
            labels: {
              fontSize: 14,
              fontFamily: "Arial,sans-serif"
            }

          },
          tooltips: {
            titleFontFamily: "Arial",
            xPadding: 15,
            yPadding: 10,
            caretPadding: 0,
            bodyFontSize: 16,
          }
        }
      });
    }

  } catch (error) {
    console.log(error);
  }

  try {
    //Sales chart
    var ctx = document.getElementById("sales-chart");
    if (ctx) {
      ctx.height = 150;
      var myChart = new Chart(ctx, {
        type: 'line',
        data: {
          labels: ["2010", "2011", "2012", "2013", "2014", "2015", "2016"],
          type: 'line',
          defaultFontFamily: 'Arial',
          datasets: [{
            label: "Foods",
            data: [0, 30, 10, 120, 50, 63, 10],
            backgroundColor: 'transparent',
            borderColor: 'rgba(220,53,69,0.75)',
            borderWidth: 3,
            pointStyle: 'circle',
            pointRadius: 5,
            pointBorderColor: 'transparent',
            pointBackgroundColor: 'rgba(220,53,69,0.75)',
          }, {
            label: "Electronics",
            data: [0, 50, 40, 80, 40, 79, 120],
            backgroundColor: 'transparent',
            borderColor: 'rgba(40,167,69,0.75)',
            borderWidth: 3,
            pointStyle: 'circle',
            pointRadius: 5,
            pointBorderColor: 'transparent',
            pointBackgroundColor: 'rgba(40,167,69,0.75)',
          }]
        },
        options: {
          responsive: true,
          tooltips: {
            mode: 'index',
            titleFontSize: 12,
            titleFontColor: '#000',
            bodyFontColor: '#000',
            backgroundColor: '#fff',
            titleFontFamily: 'Arial',
            bodyFontFamily: 'Arial',
            cornerRadius: 3,
            intersect: false,
          },
          legend: {
            display: false,
            labels: {
              usePointStyle: true,
              fontFamily: 'Arial',
            },
          },
          scales: {
            xAxes: [{
              display: true,
              gridLines: {
                display: false,
                drawBorder: false
              },
              scaleLabel: {
                display: false,
                labelString: 'Month'
              },
              ticks: {
                fontFamily: "Arial"
              }
            }],
            yAxes: [{
              display: true,
              gridLines: {
                display: false,
                drawBorder: false
              },
              scaleLabel: {
                display: true,
                labelString: 'Value',
                fontFamily: "Arial"

              },
              ticks: {
                fontFamily: "Arial"
              }
            }]
          },
          title: {
            display: false,
            text: 'Normal Legend'
          }
        }
      });
    }


  } catch (error) {
    console.log(error);
  }

  try {

    //Team chart
      var ctx = document.getElementById("team-chart"); // Lấy phần tử HTML có ID là "team-chart"

      if (ctx) { // Nếu phần tử tồn tại
          ctx.height = 100; // Đặt chiều cao của nó thành 100

          var myChart = new Chart(ctx, { // Tạo một đối tượng biểu đồ mới
              type: 'line', // Loại biểu đồ là biểu đồ đường
              data: { // Dữ liệu cho biểu đồ
                  labels: ["Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11"], // Nhãn cho trục x
                  type: 'line', // Loại dữ liệu là đường
                  defaultFontFamily: 'Arial', // Phông chữ mặc định cho biểu đồ là Arial
                  datasets: [{ // Bộ dữ liệu cho biểu đồ
                      data: [4, 7, 9, 8, 10, 12, 15], // Dữ liệu cho biểu đồ
                      label: "Doanh thu", // Nhãn cho dữ liệu
                      backgroundColor: 'rgba(81, 190, 32,.15)', // Màu nền cho biểu đồ
                      borderColor: 'rgba(81, 190, 32,0.5)', // Màu viền cho biểu đồ
                      borderWidth: 3.5, // Độ rộng viền cho biểu đồ
                      pointStyle: 'circle', // Kiểu điểm cho biểu đồ
                      pointRadius: 5, // Bán kính điểm cho biểu đồ
                      pointBorderColor: 'transparent', // Màu viền điểm cho biểu đồ
                      pointBackgroundColor: 'rgba(81, 190, 32,0.5)', // Màu nền điểm cho biểu đồ
                  },]
              },
              options: { // Các tùy chọn cho biểu đồ
                  responsive: true, // Biểu đồ sẽ tự động điều chỉnh kích thước để phù hợp với khung nhìn
                  tooltips: { // Các gợi ý khi di chuột qua các điểm dữ liệu
                      mode: 'index', // Chế độ hiển thị gợi ý
                      titleFontSize: 12, // Kích thước phông chữ cho tiêu đề gợi ý
                      titleFontColor: '#000', // Màu sắc phông chữ cho tiêu đề gợi ý
                      bodyFontColor: '#000', // Màu sắc phông chữ cho nội dung gợi ý
                      backgroundColor: '#fff', // Màu nền cho gợi ý
                      titleFontFamily: 'Arial', // Phông chữ cho tiêu đề gợi ý
                      bodyFontFamily: 'Arial', // Phông chữ cho nội dung gợi ý
                      cornerRadius: 3, // Bán kính góc cho gợi ý
                      intersect: false, // Không cho phép giao nhau giữa các gợi ý
                  },
                  legend: { // Chú thích cho biểu đồ
                      display: false, // Không hiển thị chú thích
                      position: 'top', // Vị trí của chú thích
                      labels: { // Nhãn cho chú thích
                          usePointStyle: true, // Sử dụng kiểu điểm cho nhãn
                          fontFamily: 'Arial', // Phông chữ cho nhãn
                      },
                  },
                  scales: { // Quy mô cho biểu đồ
                      xAxes: [{ // Trục x
                          display: true, // Hiển thị trục x
                          gridLines: { // Đường lưới cho trục x
                              display: false, // Không hiển thị đường lưới
                              drawBorder: false // Không vẽ viền cho đường lưới
                          },
                          scaleLabel: { // Nhãn cho trục x
                              display: false, // Không hiển thị nhãn
                              labelString: 'Month' // Chuỗi nhãn
                          },
                          ticks: { // Đánh dấu trên trục x
                              fontFamily: "Arial" // Phông chữ cho đánh dấu
                          }
                      }],
                      yAxes: [{ // Trục y
                          display: true, // Hiển thị trục y
                          gridLines: { // Đường lưới cho trục y
                              display: false, // Không hiển thị đường lưới
                              drawBorder: false // Không vẽ viền cho đường lưới
                          },
                          scaleLabel: { // Nhãn cho trục y
                              display: true, // Hiển thị nhãn
                              labelString: '(Triệu đồng)', // Chuỗi nhãn
                              fontFamily: "Arial" // Phông chữ cho nhãn
                          },
                          ticks: { // Đánh dấu trên trục y
                              fontFamily: "Arial" // Phông chữ cho đánh dấu
                          }
                      }]
                  },

                  title: { // Tiêu đề cho biểu đồ
                      display: false, // Không hiển thị tiêu đề
                  }
              }
          });
      }

  } catch (error) {
      console.log(error); // Nếu có lỗi, in lỗi ra console
  }

  try {
    //bar chart
    var ctx = document.getElementById("barChart");
    if (ctx) {
      ctx.height = 200;
      var myChart = new Chart(ctx, {
        type: 'bar',
        defaultFontFamily: 'Arial',
        data: {
          labels: ["January", "February", "March", "April", "May", "June", "July"],
          datasets: [
            {
              label: "My First dataset",
              data: [65, 59, 80, 81, 56, 55, 40],
              borderColor: "rgba(0, 123, 255, 0.9)",
              borderWidth: "0",
              backgroundColor: "rgba(0, 123, 255, 0.5)",
              fontFamily: "Arial"
            },
            {
              label: "My Second dataset",
              data: [28, 48, 40, 19, 86, 27, 90],
              borderColor: "rgba(0,0,0,0.09)",
              borderWidth: "0",
              backgroundColor: "rgba(0,0,0,0.07)",
              fontFamily: "Arial"
            }
          ]
        },
        options: {
          legend: {
            position: 'top',
            labels: {
              fontFamily: 'Arial'
            }

          },
          scales: {
            xAxes: [{
              ticks: {
                fontFamily: "Arial"

              }
            }],
            yAxes: [{
              ticks: {
                beginAtZero: true,
                fontFamily: "Arial"
              }
            }]
          }
        }
      });
    }


  } catch (error) {
    console.log(error);
  }

  try {

    //radar chart
    var ctx = document.getElementById("radarChart");
    if (ctx) {
      ctx.height = 200;
      var myChart = new Chart(ctx, {
        type: 'radar',
        data: {
          labels: [["Eating", "Dinner"], ["Drinking", "Water"], "Sleeping", ["Designing", "Graphics"], "Coding", "Cycling", "Running"],
          defaultFontFamily: 'Arial',
          datasets: [
            {
              label: "My First dataset",
              data: [65, 59, 66, 45, 56, 55, 40],
              borderColor: "rgba(0, 123, 255, 0.6)",
              borderWidth: "1",
              backgroundColor: "rgba(0, 123, 255, 0.4)"
            },
            {
              label: "My Second dataset",
              data: [28, 12, 40, 19, 63, 27, 87],
              borderColor: "rgba(0, 123, 255, 0.7",
              borderWidth: "1",
              backgroundColor: "rgba(0, 123, 255, 0.5)"
            }
          ]
        },
        options: {
          legend: {
            position: 'top',
            labels: {
              fontFamily: 'Arial'
            }

          },
          scale: {
            ticks: {
              beginAtZero: true,
              fontFamily: "Arial"
            }
          }
        }
      });
    }

  } catch (error) {
    console.log(error)
    }


  try {

    //line chart
    var ctx = document.getElementById("lineChart");
    if (ctx) {
      ctx.height = 150;
      var myChart = new Chart(ctx, {
        type: 'line',
        data: {
          labels: ["January", "February", "March", "April", "May", "June", "July"],
          defaultFontFamily: "Arial",
          datasets: [
            {
              label: "My First dataset",
              borderColor: "rgba(0,0,0,.09)",
              borderWidth: "1",
              backgroundColor: "rgba(0,0,0,.07)",
              data: [22, 44, 67, 43, 76, 45, 12]
            },
            {
              label: "My Second dataset",
              borderColor: "rgba(0, 123, 255, 0.9)",
              borderWidth: "1",
              backgroundColor: "rgba(0, 123, 255, 0.5)",
              pointHighlightStroke: "rgba(26,179,148,1)",
              data: [16, 32, 18, 26, 42, 33, 44]
            }
          ]
        },
        options: {
          legend: {
            position: 'top',
            labels: {
              fontFamily: 'Arial'
            }

          },
          responsive: true,
          tooltips: {
            mode: 'index',
            intersect: false
          },
          hover: {
            mode: 'nearest',
            intersect: true
          },
          scales: {
            xAxes: [{
              ticks: {
                fontFamily: "Arial"

              }
            }],
            yAxes: [{
              ticks: {
                beginAtZero: true,
                fontFamily: "Arial"
              }
            }]
          }

        }
      });
    }


  } catch (error) {
    console.log(error);
  }


  try {

    //doughut chart
   var ctx = document.getElementById("doughutChart"); // Lấy phần tử HTML có ID là "doughutChart"

      if (ctx) { // Nếu phần tử tồn tại
          ctx.height = 150; // Đặt chiều cao của nó thành 150

          var myChart = new Chart(ctx, { // Tạo một đối tượng biểu đồ mới
              type: 'doughnut', // Loại biểu đồ là biểu đồ doughnut

              data: { // Dữ liệu cho biểu đồ
                  datasets: [{ // Bộ dữ liệu cho biểu đồ
                      data: [45, 25, 20, 10], // Dữ liệu số liệu cho từng phần của biểu đồ
                      backgroundColor: [ // Màu nền cho từng phần
                          '#00b5e9', '#fa4251', '#216C53', '#EA4B33'
                      ],
                      hoverBackgroundColor: [ // Màu nền khi di chuột qua
                          '#00b5e9', '#fa4251', '#216C53', '#EA4B33'
                      ]
                  }],
                  labels: [ // Nhãn cho từng phần
                      'Hoàn tất',
                      'Xử lý', 'Đang giao', 'Đơn húy'
                  ]
              },

              options: { // Các tùy chọn cho biểu đồ
                  legend: { // Cấu hình chú thích
                      position: 'top', // Vị trí chú thích
                      labels: { // Cấu hình font chữ cho nhãn
                          fontFamily: 'Arial' // Font chữ Arial
                      }
                  },
                  responsive: true // Biểu đồ sẽ tương thích với kích thước màn hình
              }
          });
      }

  } catch (error) {
      console.log(error); // Nếu có lỗi, in ra console
  }


  try {

    //pie chart
    var ctx = document.getElementById("pieChart");
    if (ctx) {
      ctx.height = 200;
      var myChart = new Chart(ctx, {
        type: 'pie',
        data: {
          datasets: [{
            data: [45, 25, 20, 10],
            backgroundColor: [
              "rgba(0, 123, 255,0.9)",
              "rgba(0, 123, 255,0.7)",
              "rgba(0, 123, 255,0.5)",
              "rgba(0,0,0,0.07)"
            ],
            hoverBackgroundColor: [
              "rgba(0, 123, 255,0.9)",
              "rgba(0, 123, 255,0.7)",
              "rgba(0, 123, 255,0.5)",
              "rgba(0,0,0,0.07)"
            ]

          }],
          labels: [
            "Green",
            "Green",
            "Green"
          ]
        },
        options: {
          legend: {
            position: 'top',
            labels: {
              fontFamily: 'Arial'
            }

          },
          responsive: true
        }
      });
    }


  } catch (error) {
    console.log(error);
  }

  try {

    // polar chart
    var ctx = document.getElementById("polarChart");
    if (ctx) {
      ctx.height = 200;
      var myChart = new Chart(ctx, {
        type: 'polarArea',
        data: {
          datasets: [{
            data: [15, 18, 9, 6, 19],
            backgroundColor: [
              "rgba(0, 123, 255,0.9)",
              "rgba(0, 123, 255,0.8)",
              "rgba(0, 123, 255,0.7)",
              "rgba(0,0,0,0.2)",
              "rgba(0, 123, 255,0.5)"
            ]

          }],
          labels: [
            "Green",
            "Green",
            "Green",
            "Green"
          ]
        },
        options: {
          legend: {
            position: 'top',
            labels: {
              fontFamily: 'Arial'
            }

          },
          responsive: true
        }
      });
    }

  } catch (error) {
    console.log(error);
  }

    try {
    var ctx = document.getElementById("singelBarChart"); // Lấy phần tử HTML có ID là "singelBarChart"
    if (ctx) { // Nếu phần tử tồn tại
        ctx.height = 150; // Đặt chiều cao của nó thành 150
        var myChart = new Chart(ctx, { // Tạo một đối tượng biểu đồ mới
            type: 'bar', // Loại biểu đồ là biểu đồ cột
            data: { // Dữ liệu cho biểu đồ
                labels: ["Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11"], // Nhãn cho trục x
                datasets: [{ // Bộ dữ liệu cho biểu đồ
                    label: "Người đăng ký mới", // Nhãn cho dữ liệu
                    data: [50, 75, 90, 120, 150, 200, 250], // Dữ liệu số liệu cho từng cột
                    borderColor: "#000000", // Màu viền cho cột
                    borderWidth: "0", // Độ rộng viền cho cột
                    backgroundColor: "#F14773" // Màu nền cho cột
                }]
            },
            options: { // Các tùy chọn cho biểu đồ
                legend: { // Cấu hình chú thích
                    position: 'top', // Vị trí chú thích
                    labels: { // Cấu hình font chữ cho nhãn
                        fontFamily: 'Arial' // Font chữ Arial
                    }
                },
                scales: { // Quy mô cho biểu đồ
                    xAxes: [{ // Trục x
                        ticks: { // Đánh dấu trên trục x
                            fontFamily: "Arial" // Phông chữ cho đánh dấu
                        }
                    }],
                    yAxes: [{ // Trục y
                        ticks: { // Đánh dấu trên trục y
                            beginAtZero: true, // Bắt đầu từ 0
                            fontFamily: "Arial" // Phông chữ cho đánh dấu
                        }
                    }]
                }
            }
        });
    }
} catch (error) {
    console.log(error); // Nếu có lỗi, in ra console
}

})(jQuery);



(function ($) {
    // USE STRICT
    "use strict";
    var navbars = ['header', 'aside'];
    var hrefSelector = 'a:not([target="_blank"]):not([href^="#"]):not([class^="chosen-single"])';
    var linkElement = navbars.map(element => element + ' ' + hrefSelector).join(', ');
    $(".animsition").animsition({
      inClass: 'fade-in',
      outClass: 'fade-out',
      inDuration: 900,
      outDuration: 900,
      linkElement: linkElement,
      loading: true,
      loadingParentElement: 'html',
      loadingClass: 'page-loader',
      loadingInner: '<div class="page-loader__spin"></div>',
      timeout: false,
      timeoutCountdown: 5000,
      onLoadEvent: true,
      browser: ['animation-duration', '-webkit-animation-duration'],
      overlay: false,
      overlayClass: 'animsition-overlay-slide',
      overlayParentElement: 'html',
      transition: function (url) {
        window.location.href = url;
      }
    });
  
  
  })(jQuery);
(function ($) {
  // USE STRICT
  "use strict";

  // Map
  try {

    var vmap = $('#vmap');
    if(vmap[0]) {
      vmap.vectorMap( {
        map: 'world_en',
        backgroundColor: null,
        color: '#ffffff',
        hoverOpacity: 0.7,
        selectedColor: '#1de9b6',
        enableZoom: true,
        showTooltip: true,
        values: sample_data,
        scaleColors: [ '#1de9b6', '#03a9f5'],
        normalizeFunction: 'polynomial'
      });
    }

  } catch (error) {
    console.log(error);
  }

  // Europe Map
  try {
    
    var vmap1 = $('#vmap1');
    if(vmap1[0]) {
      vmap1.vectorMap( {
        map: 'europe_en',
        color: '#007BFF',
        borderColor: '#fff',
        backgroundColor: '#fff',
        enableZoom: true,
        showTooltip: true
      });
    }

  } catch (error) {
    console.log(error);
  }

  // USA Map
  try {
    
    var vmap2 = $('#vmap2');

    if(vmap2[0]) {
      vmap2.vectorMap( {
        map: 'usa_en',
        color: '#007BFF',
        borderColor: '#fff',
        backgroundColor: '#fff',
        enableZoom: true,
        showTooltip: true,
        selectedColor: null,
        hoverColor: null,
        colors: {
            mo: '#001BFF',
            fl: '#001BFF',
            or: '#001BFF'
        },
        onRegionClick: function ( event, code, region ) {
            event.preventDefault();
        }
      });
    }

  } catch (error) {
    console.log(error);
  }

  // Germany Map
  try {
    
    var vmap3 = $('#vmap3');
    if(vmap3[0]) {
      vmap3.vectorMap( {
        map: 'germany_en',
        color: '#007BFF',
        borderColor: '#fff',
        backgroundColor: '#fff',
        onRegionClick: function ( element, code, region ) {
            var message = 'You clicked "' + region + '" which has the code: ' + code.toUpperCase();

            alert( message );
        }
      });
    }
    
  } catch (error) {
    console.log(error);
  }
  
  // France Map
  try {
    
    var vmap4 = $('#vmap4');
    if(vmap4[0]) {
      vmap4.vectorMap( {
        map: 'france_fr',
        color: '#007BFF',
        borderColor: '#fff',
        backgroundColor: '#fff',
        enableZoom: true,
        showTooltip: true
      });
    }

  } catch (error) {
    console.log(error);
  }

  // Russia Map
  try {
    var vmap5 = $('#vmap5');
    if(vmap5[0]) {
      vmap5.vectorMap( {
        map: 'russia_en',
        color: '#007BFF',
        borderColor: '#fff',
        backgroundColor: '#fff',
        hoverOpacity: 0.7,
        selectedColor: '#999999',
        enableZoom: true,
        showTooltip: true,
        scaleColors: [ '#C8EEFF', '#006491' ],
        normalizeFunction: 'polynomial'
      });
    }


  } catch (error) {
    console.log(error);
  }
  
  // Brazil Map
  try {
    
    var vmap6 = $('#vmap6');
    if(vmap6[0]) {
      vmap6.vectorMap( {
        map: 'brazil_br',
        color: '#007BFF',
        borderColor: '#fff',
        backgroundColor: '#fff',
        onRegionClick: function ( element, code, region ) {
            var message = 'You clicked "' + region + '" which has the code: ' + code.toUpperCase();
            alert( message );
        }
      });
    }

  } catch (error) {
    console.log(error);
  }
})(jQuery);
(function ($) {
  // Use Strict
  "use strict";
  try {
    var progressbarSimple = $('.js-progressbar-simple');
    progressbarSimple.each(function () {
      var that = $(this);
      var executed = false;
      $(window).on('load', function () {

        that.waypoint(function () {
          if (!executed) {
            executed = true;
            /*progress bar*/
            that.progressbar({
              update: function (current_percentage, $this) {
                $this.find('.js-value').html(current_percentage + '%');
              }
            });
          }
        }, {
            offset: 'bottom-in-view'
          });

      });
    });
  } catch (err) {
    console.log(err);
  }
})(jQuery);
(function ($) {
  // USE STRICT
  "use strict";

  // Scroll Bar
  try {
    var jscr1 = $('.js-scrollbar1');
    if(jscr1[0]) {
      const ps1 = new PerfectScrollbar('.js-scrollbar1');      
    }

    var jscr2 = $('.js-scrollbar2');
    if (jscr2[0]) {
      const ps2 = new PerfectScrollbar('.js-scrollbar2');

    }

  } catch (error) {
    console.log(error);
  }

})(jQuery);
(function ($) {
  // USE STRICT
  "use strict";

  // Select 2
  try {

    $(".js-select2").each(function () {
      $(this).select2({
        minimumResultsForSearch: 20,
        dropdownParent: $(this).next('.dropDownSelect2')
      });
    });

  } catch (error) {
    console.log(error);
  }


})(jQuery);
(function ($) {
  // USE STRICT
  "use strict";

  // Dropdown 
  try {
    var menu = $('.js-item-menu');
    var sub_menu_is_showed = -1;

    for (var i = 0; i < menu.length; i++) {
      $(menu[i]).on('click', function (e) {
        e.preventDefault();
        $('.js-right-sidebar').removeClass("show-sidebar");        
        if (jQuery.inArray(this, menu) == sub_menu_is_showed) {
          $(this).toggleClass('show-dropdown');
          sub_menu_is_showed = -1;
        }
        else {
          for (var i = 0; i < menu.length; i++) {
            $(menu[i]).removeClass("show-dropdown");
          }
          $(this).toggleClass('show-dropdown');
          sub_menu_is_showed = jQuery.inArray(this, menu);
        }
      });
    }
    $(".js-item-menu, .js-dropdown").click(function (event) {
      event.stopPropagation();
    });

    $("body,html").on("click", function () {
      for (var i = 0; i < menu.length; i++) {
        menu[i].classList.remove("show-dropdown");
      }
      sub_menu_is_showed = -1;
    });

  } catch (error) {
    console.log(error);
  }

  var wW = $(window).width();
    // Right Sidebar
    var right_sidebar = $('.js-right-sidebar');
    var sidebar_btn = $('.js-sidebar-btn');

    sidebar_btn.on('click', function (e) {
      e.preventDefault();
      for (var i = 0; i < menu.length; i++) {
        menu[i].classList.remove("show-dropdown");
      }
      sub_menu_is_showed = -1;
      right_sidebar.toggleClass("show-sidebar");
    });

    $(".js-right-sidebar, .js-sidebar-btn").click(function (event) {
      event.stopPropagation();
    });

    $("body,html").on("click", function () {
      right_sidebar.removeClass("show-sidebar");

    });
 

  // Sublist Sidebar
  try {
    var arrow = $('.js-arrow');
    arrow.each(function () {
      var that = $(this);
      that.on('click', function (e) {
        e.preventDefault();
        that.find(".arrow").toggleClass("up");
        that.toggleClass("open");
        that.parent().find('.js-sub-list').slideToggle("250");
      });
    });

  } catch (error) {
    console.log(error);
  }


  try {
    // Hamburger Menu
    $('.hamburger').on('click', function () {
      $(this).toggleClass('is-active');
      $('.navbar-mobile').slideToggle('500');
    });
    $('.navbar-mobile__list li.has-dropdown > a').on('click', function () {
      var dropdown = $(this).siblings('ul.navbar-mobile__dropdown');
      $(this).toggleClass('active');
      $(dropdown).slideToggle('500');
      return false;
    });
  } catch (error) {
    console.log(error);
  }
})(jQuery);
(function ($) {
  // USE STRICT
  "use strict";

  // Load more
  try {
    var list_load = $('.js-list-load');
    if (list_load[0]) {
      list_load.each(function () {
        var that = $(this);
        that.find('.js-load-item').hide();
        var load_btn = that.find('.js-load-btn');
        load_btn.on('click', function (e) {
          $(this).text("Loading...").delay(1500).queue(function (next) {
            $(this).hide();
            that.find(".js-load-item").fadeToggle("slow", 'swing');
          });
          e.preventDefault();
        });
      })

    }
  } catch (error) {
    console.log(error);
  }

})(jQuery);
document.getElementById('checkAll').addEventListener('click', function () {
    var checkboxes = document.querySelectorAll('.checkbox');
    for (var checkbox of checkboxes) {
        checkbox.checked = this.checked;
    }
});
(function ($) {
  // USE STRICT
  "use strict";

  try {
    
    $('[data-toggle="tooltip"]').tooltip();

  } catch (error) {
    console.log(error);
  }

  // Chatbox
  try {
    var inbox_wrap = $('.js-inbox');
    var message = $('.au-message__item');
    message.each(function(){
      var that = $(this);

      that.on('click', function(){
        $(this).parent().parent().parent().toggleClass('show-chat-box');
      });
    });
    

  } catch (error) {
    console.log(error);
  }

})(jQuery);

//function removeImage(wrapId) {
//    var imgWrap = document.getElementById(wrapId);
//    if (imgWrap) {
//        imgWrap.remove();
//    }
//}

//function addNewImage() {
//    var fileInput = document.getElementById('new-image-input');
//    var newImage = fileInput.files[0];
//    if (newImage) {
//        var reader = new FileReader();
//        reader.onload = function(e) {
//            var imgWrap = document.createElement('div');
//            imgWrap.className = 'img-wrap';
//            var closeBtn = document.createElement('span');
//            closeBtn.className = 'close';
//            closeBtn.innerHTML = '×';
//            closeBtn.onclick = function() { this.parentNode.remove(); };
//            var img = document.createElement('img');
//            img.src = e.target.result;
//            img.style.width = '100px';
//            img.style.height = '100px';
//            imgWrap.appendChild(closeBtn);
//            imgWrap.appendChild(img);
//            document.getElementById('album-container').appendChild(imgWrap);
//        }
//        reader.readAsDataURL(newImage);
//    }
//    fileInput.value = ''; // Reset the file input after adding the image
//}

//function removeElement(elementId) {
//    var element = document.getElementById(elementId);
//    if (element) {
//        element.remove();
//    }
//}

//function removeImageAndShowInput(imageWrapId, inputContainerId) {
//    var imageWrap = document.getElementById(imageWrapId);
//    var inputContainer = document.getElementById(inputContainerId);
//    if (imageWrap && inputContainer) {
//        imageWrap.remove();
//        inputContainer.style.display = 'block';
//    }
//}


//function removeImageAndShowInput(imageWrapId, inputContainerId) {
//    var imageWrap = document.getElementById(imageWrapId);
//    var inputContainer = document.getElementById(inputContainerId);
//    if (imageWrap && inputContainer) {
//        imageWrap.remove(); // Xóa ảnh
//        inputContainer.style.display = 'block'; // Hiển thị lại nút "Choose File"
//    }
//}

//function previewAndHideInput() {
//    var fileInput = document.getElementById('file-input');
//    var file = fileInput.files[0];
//    if (file) {
//        var reader = new FileReader();
//        reader.onload = function (e) {
//            var imgWrap = document.createElement('div');
//            imgWrap.className = 'img-wrap';
//            imgWrap.id = 'new-product-image-wrap';

//            var closeBtn = document.createElement('span');
//            closeBtn.className = 'close';
//            closeBtn.textContent = '×';
//            closeBtn.onclick = function () {
//                imgWrap.remove(); // Xóa ảnh mới và dấu "x"
//                document.getElementById('file-input-container').style.display = 'block'; // Hiển thị lại nút "Choose File"
//            };

//            var img = document.createElement('img');
//            img.src = e.target.result;
//            img.alt = 'Ảnh sản phẩm';
//            img.style.width = '100px';
//            img.style.height = '100px';

//            imgWrap.appendChild(closeBtn);
//            imgWrap.appendChild(img);

//            var container = document.getElementById('image-upload-container');
//            container.innerHTML = '';
//            container.appendChild(imgWrap);
//        };
//        reader.readAsDataURL(file);
//        document.getElementById('file-input-container').style.display = 'none'; // Ẩn nút "Choose File" sau khi chọn ảnh mới
//    }
//}

function addImagesToAlbum() {
    var files = document.getElementById('file-multiple-input').files;// Lấy tất cả các file từ input file
    var albumContainer = document.getElementById('album-container');// Lấy phần tử chứa album

    for (var i = 0; i < files.length; i++) {// Duyệt qua từng file
        var file = files[i]; // Lấy file thứ i
        var reader = new FileReader(); // Tạo một FileReader mới
        reader.onload = function (e) {// Định nghĩa hàm sẽ được gọi khi FileReader hoàn thành việc đọc file
            var imgWrap = document.createElement('div');// Tạo một thẻ div mới
            imgWrap.className = 'img-wrap';// Đặt tên lớp cho thẻ div

            var closeBtn = document.createElement('span');// Tạo một nút đóng mới
            closeBtn.className = 'close';// Đặt tên lớp cho nút đóng
            closeBtn.textContent = '×';// Đặt nội dung văn bản cho nút đóng
            closeBtn.onclick = function () {// Định nghĩa hàm sẽ được gọi khi nút đóng được nhấp
                this.parentNode.remove();// Xóa thẻ div chứa hình ảnh và nút đóng
            };

            var img = document.createElement('img');// Tạo một thẻ img mới
            img.src = e.target.result;// Đặt src cho thẻ img bằng kết quả của FileReader
            img.alt = 'Ảnh sản phẩm';// Đặt alt cho thẻ img
            img.style.width = '100px';// Đặt chiều rộng cho thẻ img
            img.style.height = '100px';// Đặt chiều cao cho thẻ img

            imgWrap.appendChild(closeBtn);// Thêm nút đóng vào thẻ div
            imgWrap.appendChild(img);// Thêm thẻ img vào thẻ div
            albumContainer.appendChild(imgWrap);// Thêm thẻ div chứa hình ảnh và nút đóng vào album
        };
        reader.readAsDataURL(file);// Bắt đầu đọc file dưới dạng URL dữ liệu
    }
}

function replaceSingleImage() {
    var fileInput = document.getElementById('single-image-input');// Lấy phần tử input file
    var file = fileInput.files[0]; // Lấy file đầu tiên từ input file
    if (file) {// Kiểm tra xem có file nào được chọn không
        var reader = new FileReader();// Tạo một FileReader mới
        reader.onload = function (e) {// Định nghĩa hàm sẽ được gọi khi FileReader hoàn thành việc đọc file
            var imgWrap = document.getElementById('single-image-wrap');// Lấy phần tử chứa hình ảnh
            var img = document.getElementById('single-product-image');// Lấy phần tử hình ảnh
            img.src = e.target.result; // Đặt src cho thẻ img bằng kết quả của FileReader
            imgWrap.style.display = 'block'; // Hiển thị lại ảnh và nút xóa
        };
        reader.readAsDataURL(file);// Bắt đầu đọc file dưới dạng URL dữ liệu
    }
}

function removeSingleImage() {
    var imgWrap = document.getElementById('single-image-wrap');// Lấy phần tử chứa hình ảnh
    imgWrap.style.display = 'none'; // Ẩn ảnh và nút xóa
    document.getElementById('single-image-input').value = ''; // Đặt lại giá trị của input file
}

//function displaySingleImage() {
//    var fileInput = document.getElementById('single-image-input');
//    var file = fileInput.files[0];
//    if (file) {
//        var reader = new FileReader();
//        reader.onload = function (e) {
//            var imgWrap = document.createElement('div');
//            imgWrap.className = 'img-wrap';

//            var closeBtn = document.createElement('span');
//            closeBtn.className = 'close';
//            closeBtn.textContent = '×';
//            closeBtn.onclick = function () {
//                imgWrap.remove();
//                fileInput.value = ''; // Đặt lại giá trị của input file
//            };

//            var img = document.createElement('img');
//            img.id = 'single-product-image';
//            img.src = e.target.result;
//            img.alt = 'Ảnh sản phẩm';
//            img.style.width = '100px';
//            img.style.height = '100px';

//            imgWrap.appendChild(closeBtn);
//            imgWrap.appendChild(img);

//            var container = document.getElementById('single-image-container');
//            container.innerHTML = ''; // Xóa ảnh cũ nếu có
//            container.appendChild(imgWrap);
//        };
//        reader.readAsDataURL(file);
//    }
//}
//function addImagesToAlbum() {
//    var files = document.getElementById('file-multiple-input').files;
//    var albumContainer = document.getElementById('album-container');

//    for (var i = 0; i < files.length; i++) {
//        var file = files[i];
//        var reader = new FileReader();
//        reader.onload = function (e) {
//            var imgWrap = document.createElement('div');
//            imgWrap.className = 'img-wrap';
//            imgWrap.style.marginRight = '10px'; // Thêm khoảng cách giữa các ảnh

//            var closeBtn = document.createElement('span');
//            closeBtn.className = 'close';
//            closeBtn.textContent = '×';
//            closeBtn.onclick = function () {
//                this.parentNode.remove();
//            };

//            var img = document.createElement('img');
//            img.src = e.target.result;
//            img.alt = 'Ảnh sản phẩm';
//            img.style.width = '100px';
//            img.style.height = '100px';

//            imgWrap.appendChild(closeBtn);
//            imgWrap.appendChild(img);
//            albumContainer.appendChild(imgWrap);
//        };
//        reader.readAsDataURL(file);
//    }
//}



function validateFieldsAndRedirect() {
    // Giả sử bạn có các trường với id là 'name', 'price', và 'description'
    var name = document.getElementById('name').value;
    var idt = document.getElementById('idt').value;

    // Kiểm tra xem các trường có rỗng không
    if (!name || !idt ) {
        alert('Vui lòng điền đầy đủ thông tin các trường có đánh dấu *');
        return; // Ngăn không cho chuyển trang nếu thông tin không đầy đủ
    }

    // Thêm các điều kiện kiểm tra khác nếu cần thiết
    // ...

    // Nếu tất cả các điều kiện kiểm tra đều hợp lệ, chuyển đến trang mục tiêu
    window.location.href = 'product.html';
}

function validateFieldsAndRedirectC() {
    // Giả sử bạn có các trường với id là 'name', 'price', và 'description'
    var name = document.getElementById('name').value;
    var idt = document.getElementById('idt').value;

    // Kiểm tra xem các trường có rỗng không
    if (!name || !idt) {
        alert('Vui lòng điền đầy đủ thông tin các trường có đánh dấu *');
        return; // Ngăn không cho chuyển trang nếu thông tin không đầy đủ
    }

    // Thêm các điều kiện kiểm tra khác nếu cần thiết
    // ...

    // Nếu tất cả các điều kiện kiểm tra đều hợp lệ, chuyển đến trang mục tiêu
    window.location.href = 'catagory.html';
}


function xoaDongNay(element) {
    // Tìm phần tử tr cha của nút và xóa nó
    var dongCanXoa = element.closest('tr');

    // Xóa dòng trên nếu có
    var dongTren = dongCanXoa.previousElementSibling;
    if (dongTren) {
        dongTren.remove();
    }

    // Xóa dòng hiện tại
    dongCanXoa.remove();
}

function validateFieldsAndRedirectS() {
    // Giả sử bạn có các trường với id là 'name', 'price', và 'description'
    var name = document.getElementById('name').value;
    var idt = document.getElementById('idt').value;

    // Kiểm tra xem các trường có rỗng không
    if (!name || !idt) {
        alert('Vui lòng điền đầy đủ thông tin các trường có đánh dấu *');
        return; // Ngăn không cho chuyển trang nếu thông tin không đầy đủ
    }

    // Thêm các điều kiện kiểm tra khác nếu cần thiết
    // ...

    // Nếu tất cả các điều kiện kiểm tra đều hợp lệ, chuyển đến trang mục tiêu
    window.location.href = 'saleprog.html';
}